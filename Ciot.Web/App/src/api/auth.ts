import * as v from "valibot";
import * as schemas from "../schemas";
import { getUrl } from "../config/urls";
import { NetworkError } from "../exceptions/NetworkError";

export async function login(email: string, password: string) {
  const response = await fetch(getUrl("/api/v1/auth/login", {}), {
    method: "POST",
    body: JSON.stringify({
      email,
      password,
    }),
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (!response.ok) {
    if (response.status === 401) {
      return v.parse(schemas.LoginResponseSchema, await response.json());
    }

    throw new Error("Network response was not ok");
  }

  const data = v.parse(schemas.LoginResponseSchema, await response.json());

  localStorage.setItem("authorized", "true");
  localStorage.setItem("user", JSON.stringify(data.user));

  return data;
}

export async function signOut(): Promise<void> {
  if (localStorage.getItem("authorized") !== "true") return;

  const response = await fetch(getUrl("/api/v1/auth/signout", {}), {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (!response.ok) {
    throw new NetworkError(
      `Network error: ${response.status} ${response.statusText}`,
    );
  }

  localStorage.removeItem("authorized");
}

export async function getUser(): Promise<schemas.User> {
  const user = localStorage.getItem("user");
  if (!user) {
    throw new Error("User not found");
  }
  return v.parse(schemas.UserSchema, JSON.parse(user));
}

export async function isAuthorized(): Promise<boolean> {
  return localStorage.getItem("authorized") === "true";
}
