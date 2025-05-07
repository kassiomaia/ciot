/* eslint-disable @typescript-eslint/no-unused-vars */
const urls = [
  "/api/v1/auth/login",
  "/api/v1/auth/signout",
  "/api/v1/devices",
  "/api/v1/devices/:deviceId",
  "/api/v1/devices/:deviceId/details",
  "/api/v1/devices/:deviceId/operations",
  "/api/v1/devices/:deviceId/operations/:operationId/execute",
] as const;

type ExtractArgs<T extends string> = T extends `${string}:${infer Param}/${infer Rest}` ? Param | ExtractArgs<`/${Rest}`>
  : T extends `${string}:${infer Param}` ? Param
    : never;

type ParsedUrl<T extends string> = T;

export const getUrl = <T extends (typeof urls)[number]>(
  url: T,
  params: Record<ExtractArgs<T>, string>,
) => {
  return url.replace(/:\w+/g, (match) => {
    const key = match.slice(1) as keyof typeof params;
    if (key in params) {
      return params[key];
    }

    return match;
  }) as ParsedUrl<T>;
};
