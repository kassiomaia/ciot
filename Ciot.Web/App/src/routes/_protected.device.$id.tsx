import * as React from "react";
import {createFileRoute} from "@tanstack/react-router";
import {
  Container,
  ContentLayout,
  CopyToClipboard,
  Header,
  KeyValuePairs,
  StatusIndicator,
} from "@cloudscape-design/components";
import {Layout} from "../components/Layout";
import * as schemas from "../schemas";

export const Route = createFileRoute("/_protected/device/$id")({
  component: DeviceIndex,
  loader: async ({context, params}) => {
    return {
      user: await context.api.auth.getUser(),
      devices: await context.api.devices.getAll(),
      device: await context.api.devices.getById(params.id),
    };
  },
});

function DeviceIndex() {
  const {devices, device, user} = Route.useLoaderData();

  console.log({ device })
  
  return (
    <Layout
      user={user!}
      devices={devices as schemas.Device[]}
      selectedDevice={device as schemas.Device}
    >
      <ContentLayout header={<Header variant="h1">Device Overview</Header>}>
        <Container
          header={
            <Header variant="h2" description="Additional information">
              Device details
            </Header>
          }
        >
          <KeyValuePairs
            columns={3}
            items={[
              {
                label: "Device ID",
                value: (
                  <CopyToClipboard
                    copyButtonAriaLabel="Copy ID"
                    copyErrorText="ID failed to copy"
                    copySuccessText="ID copied"
                    textToCopy={device.id}
                    variant="inline"
                  />
                ),
              },
              {
                label: "Device Name",
                value: device.name,
              },
              {
                label: "Status",
                value: <StatusIndicator>Available</StatusIndicator>,
              },
              {
                label: "Manufacturer",
                id: "manufacturer-id",
                value: device.manufacturer,
              },
              {
                label: "Model",
                value: device.model,
              },
              {
                label: "Serial Number",
                value: (
                  <CopyToClipboard
                    copyButtonAriaLabel="Serial Number"
                    copyErrorText="Serial Number failed to copy"
                    copySuccessText="Serial Number copied"
                    textToCopy={device.serialNumber}
                    variant="inline"
                  />
                ),
              },
            ]}
          />
        </Container>
      </ContentLayout>
    </Layout>
  );
}
