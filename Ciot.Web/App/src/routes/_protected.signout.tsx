import * as React from "react";
import { createFileRoute, Navigate } from "@tanstack/react-router";

export const Route = createFileRoute("/_protected/signout")({
  beforeLoad: async ({ context }) => {
    await context.api.auth.signOut();
  },
  component: SignOut,
});

function SignOut() {
  return <Navigate to="/login" />;
}
