import {defineConfig} from "vite";
import react from "@vitejs/plugin-react";
import {TanStackRouterVite} from "@tanstack/router-plugin/vite";
import path from "path";

export default defineConfig({
  root: "./App",
  build: {
    outDir: "../wwwroot",
  },
  plugins: [
    TanStackRouterVite({target: "react", autoCodeSplitting: true}),
    react(),
  ]
});
