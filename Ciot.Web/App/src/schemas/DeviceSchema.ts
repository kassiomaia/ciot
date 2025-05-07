import * as v from "valibot";

export const DeviceSchema = v.object({
  id: v.string(),
  name: v.string(),
  model: v.string(),
  description: v.string(),
  manufacturer: v.string(),
  serialNumber: v.string(),
  operations: v.array(
    v.object({
      id: v.string(),
      name: v.string(),
      description: v.string(),
      parameters: v.array(
        v.object({
          id: v.string(),
          name: v.string(),
          value: v.string(),
          type: v.number(),
        }),
      ),
    }),
  ),
});

export type Device = v.InferOutput<typeof DeviceSchema>;
