import * as React from "react";
import { createFileRoute, Navigate, useNavigate } from "@tanstack/react-router";
import ContentLayout from "@cloudscape-design/components/content-layout";
import Container from "@cloudscape-design/components/container";
import Header from "@cloudscape-design/components/header";
import Button from "@cloudscape-design/components/button";
import Form from "@cloudscape-design/components/form";
import SpaceBetween from "@cloudscape-design/components/space-between";
import FormField from "@cloudscape-design/components/form-field";
import Input from "@cloudscape-design/components/input";
import { Alert, Box } from "@cloudscape-design/components";

import * as schemas from "../schemas";
import * as v from "valibot";

export const Route = createFileRoute("/login")({
  component: Login,
  loader: async ({ context }) => {
    return {
      user: await context.api.auth.getUser(),
      authorized: await context.api.auth.isAuthorized(),
      loginAction: async (formData: FormData) => {
        const email = formData.get("email") as string;
        const password = formData.get("password") as string;

        if (
          !v.is(schemas.LoginInputSchema, {
            email,
            password,
          })
        ) {
          return;
        }

        try {
          const response = await context.api.auth.login(email, password);
          if (!response) {
            return { error: "Login failed" };
          }

          if (response.message) {
            return { error: response.message };
          }

          localStorage.setItem("authorized", "true");
          return true;
        } catch (error) {
          console.error("Login failed", error);
          return;
        }
      },
    };
  },
});

function Login() {
  const navigate = useNavigate();
  const [email, setEmail] = React.useState("");
  const [password, setPassword] = React.useState("");
  const [error, setError] = React.useState<string | null>(null);
  const { authorized, loginAction } = Route.useLoaderData();

  if (authorized) {
    return <Navigate to="/" />;
  }

  return (
    <ContentLayout
      defaultPadding
      headerVariant="high-contrast"
      maxContentWidth={520}
      header={
        <Header variant="h1" description="Manage your devices on the go">
          Device Management
        </Header>
      }
    >
      <form
        action={async (formData) => {
          const result = await loginAction(formData);
          // check if result contains error
          if (result && typeof result === "object" && result.error) {
            setError(result.error);
            return;
          }

          if (result) {
            await navigate("/");
          } else {
            console.error("Login failed");
          }
        }}
      >
        <Container
          header={
            <>
              <Header variant="h2">Sign in to your account</Header>
            </>
          }
          variant="stacked"
          footer={
            <SpaceBetween direction="horizontal" size="xs">
              <Button variant="link">Login</Button>
            </SpaceBetween>
          }
        >
          <Form>
            {error && (
              <Alert
                type="error"
                header="Unfortunately, we couldn't log you in"
                dismissible
                onDismiss={() => setError(null)}
              >
                <Box
                  padding={{
                    top: "s",
                    bottom: "s",
                  }}
                >
                  {error}
                </Box>
              </Alert>
            )}

            <SpaceBetween direction="vertical" size="l">
              <FormField label="Email">
                <Input
                  type="email"
                  placeholder="Enter your email"
                  name="email"
                  inputMode="email"
                  controlId="email"
                  value={email}
                  onChange={(e) => setEmail(e.detail.value)}
                />
              </FormField>
              <FormField label="Password">
                <Input
                  type="password"
                  placeholder="Enter your password"
                  name="password"
                  inputMode="text"
                  controlId="password"
                  value={password}
                  onChange={(e) => setPassword(e.detail.value)}
                />
              </FormField>
            </SpaceBetween>
          </Form>
        </Container>
      </form>
    </ContentLayout>
  );
}
