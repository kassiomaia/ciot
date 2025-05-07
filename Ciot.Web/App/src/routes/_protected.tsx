import { createFileRoute, Navigate, Outlet } from "@tanstack/react-router";
import React from "react";

export const Route = createFileRoute("/_protected")({
  component: ProtectedRoute,
  loader: async ({ context }) => {
    return {
      authorized: await context.api.auth.isAuthorized(),
    };
  },
});

function ProtectedRoute() {
  const { authorized } = Route.useLoaderData();

  if (!authorized) {
    return <Navigate to="/login" />;
  }

  return <Outlet />;
}
