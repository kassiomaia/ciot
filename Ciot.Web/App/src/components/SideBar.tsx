import React from "react";
import { SideNavigation } from "@cloudscape-design/components";
import { SideNavigationProps } from "@cloudscape-design/components/side-navigation/interfaces";

export type SideBarProps = {
  devices: {
    id: string;
    name: string;
  }[];
};

export function SideBar({ devices }: SideBarProps) {
  return (
    <SideNavigation
      activeHref="#"
      header={{
        href: "#",
        text: "Devices",
      }}
      items={[
        ...(devices.map(
          (device) =>
            ({
              type: "link",
              text: device.name,
              href: `#/device/${device.id}`,
            }) as SideNavigationProps.Item,
        ) || []),
      ]}
    />
  );
}
