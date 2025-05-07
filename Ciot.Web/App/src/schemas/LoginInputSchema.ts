import * as v from "valibot";

export const LoginInputSchema = v.object({
  email: v.pipe(v.string(), v.email()),
  password: v.string(),
});

export type LoginInput = v.InferOutput<typeof LoginInputSchema>;
