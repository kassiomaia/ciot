import * as v from "valibot";
import { UserSchema } from "./UserSchema";

export const LocalStorageSchema = v.object({
  user: v.optional(UserSchema),
});
