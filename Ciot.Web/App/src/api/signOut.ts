import {api} from "../config/client";

export function signOut(
  email: string,
  password: string,
): Promise<{ message: string } | null> {

  if (!localStorage.getItem("authorized") === "true") 
    return Promise.resolve(null);
  
  await fetch("/auth/signout", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
  });

  localStorage.removeItem("authorized");
}