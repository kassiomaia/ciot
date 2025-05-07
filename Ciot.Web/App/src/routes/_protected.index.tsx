import * as React from "react";
import { createFileRoute } from "@tanstack/react-router";
import { Layout } from "../components/Layout";
import { Header } from "@cloudscape-design/components";

export const Route = createFileRoute("/_protected/")({
  component: Index,
  loader: async ({ context }) => {
    return {
      user: await context.api.auth.getUser(),
      devices: await context.api.devices.getAll(),
    };
  },
});

function Index() {
  const { devices, user } = Route.useLoaderData();

  return (
    <Layout user={user} devices={devices}>
      <Header variant="h1">Welcome to the Cloud IoT Dashboard</Header>
    </Layout>
  );
}
