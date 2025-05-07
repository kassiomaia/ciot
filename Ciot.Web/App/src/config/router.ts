import { createHashHistory, createRouter } from "@tanstack/react-router";

import { routeTree } from "../routeTree.gen";
import * as api from "../api";

const router = createRouter({
  routeTree,
  history: createHashHistory(),
  context: {
    api,
  },
});

declare module "@tanstack/react-router" {
  interface Register {
    router: typeof router;
  }
}

export default () => {
  return router;
};
