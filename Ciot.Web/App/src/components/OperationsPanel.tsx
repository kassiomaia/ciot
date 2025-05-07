import React from "react";
import {
  Box,
  Container,
  Header,
  SplitPanel,
} from "@cloudscape-design/components";
import { OperationItem } from "./OperationItem";
import * as schemas from "../schemas";

export type OperationsPanelProps = {
  device: schemas.Device;
};

export function OperationsPanel({ device }: OperationsPanelProps) {
  return (
    <SplitPanel header="Operations">
      <Container
        variant="stacked"
        header={
          <Header
            variant="h2"
            description="Explore the operations available for this device"
          >
            Operations for {device.name}
          </Header>
        }
      >
        {device.operations.map((operation) => (
          <Box key={operation.id} variant="p" margin="xs">
            <OperationItem device={device} operation={operation} />
          </Box>
        ))}
      </Container>
    </SplitPanel>
  );
}
