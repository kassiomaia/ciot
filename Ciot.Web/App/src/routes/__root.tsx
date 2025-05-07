import React from "react";
import {
  createRootRouteWithContext,
  Navigate,
  Outlet,
} from "@tanstack/react-router";
import * as api from "../api";

export const Route = createRootRouteWithContext<{
  api: typeof api;
}>()({
  component: () => {
    return <Outlet />;
  },
  errorComponent: () => {
    return <Navigate to="/" />;
  },
});
