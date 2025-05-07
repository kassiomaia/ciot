import React from "react";
import {
  Box,
  Button,
  ExpandableSection,
  Grid, Header,
  ProgressBar,
} from "@cloudscape-design/components";
import { useRouteContext } from "@tanstack/react-router";
import FormField from "@cloudscape-design/components/form-field";
import Input from "@cloudscape-design/components/input";
import * as schemas from "../schemas";
import SpaceBetween from "@cloudscape-design/components/space-between";

export type OperationItemProps = {
  device: { id: string };
  operation: schemas.Device['operations'];
};

const useOperationExecution = () => {
  const [executing, setExecuting] = React.useState(false);
  const [status, setStatus] = React.useState<
    "in-progress" | "success" | "error" | undefined
  >(undefined);
  const [progress, setProgress] = React.useState(0);
  const [executions, setExecutions] = React.useState(0);

  const context = useRouteContext({
    from: "/_protected/device/$id",
  });

  const execute = async (deviceId: string, operationId: string, parameters: Record<string, string>) => {
    setExecuting(true);
    setStatus("in-progress");
    setProgress(0);
    setExecutions((prev) => prev + 1);

    const interval = setInterval(() => {
      setProgress((prev) => {
        if (prev >= 100) {
          clearInterval(interval);
          return 100;
        }
        return prev + 10;
      });
    }, 250);

    try {
      await context.api.devices.execute(deviceId, operationId, parameters);
      clearInterval(interval);
      setExecuting(false);
      setProgress(100);
      setStatus("success");
    } catch {
      setExecuting(false);
      clearInterval(interval);
      setStatus("error");
    }
  };

  return {
    executing,
    status,
    progress,
    executions,
    execute,
  };
};

export function OperationItem({ device, operation }: OperationItemProps) {
  const { executing, status, progress, executions, execute } =
    useOperationExecution();
  
  const [parameters, setParameters] = React.useState<Record<string, string>>({});
  
  return (
    <ExpandableSection
      key={operation.id}
      headerText={operation.name}
      variant="navigation"
    >
      <Box variant="p" fontSize="body-s" padding="xs">
        {operation.description}
      </Box>

      <Box variant="p" fontSize="body-s" margin={"xs"}>
        
        <Header variant="h3">
          Parameters
        </Header>
        <Box variant="p" fontSize="body-s" padding="xs">
          <SpaceBetween size="m">
            {operation.parameters.map((parameter) => (
              <SpaceBetween size="m" key={parameter.id}>
                <FormField
                  label={parameter.name}
                >
                  <Input
                    value={parameters[parameter.id] || ""}
                    placeholder={parameter.value}
                    type={parameter.type === 1 ? "text" : "number"}
                    onChange={evt => {
                      setParameters((prev) => ({
                        ...prev,
                        [parameter.id]: evt.detail.value,
                      }));
                    }}
                  />
                </FormField>
              </SpaceBetween>
            ))}
          </SpaceBetween>
        </Box>
        
        <Header variant="h3" margin="xs">
          Execution
        </Header>
        
        <Grid gridDefinition={[{ colspan: 10 }, { colspan: 2 }]}>
          <ProgressBar
            status={status}
            value={progress}
            additionalInfo={status === undefined
              ? "Waiting for execution"
              : status === "in-progress"
              ? `${progress}%`
              : status === "success"
              ? "Completed"
              : "Failed"}
            description={status === "success"
              ? "Operation completed successfully"
              : status === "error"
              ? "Operation failed"
              : ""}
            label={executing
              ? "Executing..."
              : executions > 0
              ? "Executed"
              : "Not executed"}
          />

          <Button
            variant="normal"
            onClick={() => execute(device.id, operation.id, parameters)}
            loading={executing}
            loadingText="Executing"
          >
            Execute
          </Button>
        </Grid>
      </Box>
    </ExpandableSection>
  );
}
