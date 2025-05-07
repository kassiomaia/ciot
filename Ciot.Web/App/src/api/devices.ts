import { NetworkError } from "../exceptions/NetworkError";
import * as v from "valibot";
import * as schemas from "../schemas";
import { getUrl } from "../config/urls";

export async function getAll(): Promise<Pick<schemas.Device, "id" | "name">[]> {
  const response = await fetch(getUrl("/api/v1/devices", {}), {
    method: "GET",
    credentials: "include",
    headers: {
      "Content-Type": "application/json",
    },
  });

  if (!response.ok) {
    throw new NetworkError(
      `Network error: ${response.status} ${response.statusText}`,
    );
  }

  return v.parse(schemas.ItemCollectionSchema, await response.json());
}

export async function getById(deviceId: string) {
  const response = await fetch(
    getUrl("/api/v1/devices/:deviceId/details", { deviceId }),
    {
      method: "GET",
      credentials: "include",
      headers: {
        "Content-Type": "application/json",
      },
    },
  );

  if (!response.ok) {
    throw new NetworkError(
      `Network error: ${response.status} ${response.statusText}`,
    );
  }

  return v.parse(schemas.DeviceSchema, await response.json());
}

export async function execute(
  deviceId: string,
  operationId: string,
  parameters: Record<string, string>,
): Promise<void> {
  const response = await fetch(
    getUrl("/api/v1/devices/:deviceId/operations/:operationId/execute", {
      deviceId,
      operationId,
    }),
    {
      method: "POST",
      credentials: "include",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        parameters,
      }),
    },
  );

  if (!response.ok) {
    throw new NetworkError(
      `Network error: ${response.status} ${response.statusText}`,
    );
  }

  await response.json();
}
