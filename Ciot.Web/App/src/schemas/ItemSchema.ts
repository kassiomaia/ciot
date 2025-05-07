import * as v from "valibot";

export const ItemSchema = v.object({
  id: v.string(),
  name: v.string(),
});

export type Item = v.InferOutput<typeof ItemSchema>;

export const ItemCollectionSchema = v.array(ItemSchema);

export type ItemCollection = v.InferOutput<typeof ItemCollectionSchema>;
