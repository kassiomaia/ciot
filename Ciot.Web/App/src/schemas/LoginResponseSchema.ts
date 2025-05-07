import * as v from "valibot";
import { UserSchema } from "./UserSchema";

export const LoginResponseSchema = v.object({
  message: v.optional(v.string()),
  user: v.optional(UserSchema),
});

export type LoginResponse = v.InferOutput<typeof LoginResponseSchema>;
