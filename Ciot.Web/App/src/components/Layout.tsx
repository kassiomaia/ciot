import {
  AppLayout,
  Flashbar,
  Header,
  HelpPanel,
  TopNavigation,
  TopNavigationProps,
} from "@cloudscape-design/components";
import { I18nProvider } from "@cloudscape-design/components/i18n";
import messages from "@cloudscape-design/components/i18n/messages/all.en";
import React from "react";
import { SideBar } from "./SideBar";
import { OperationsPanel } from "./OperationsPanel";

import * as schemas from "../schemas";

const LOCALE = "en";

export type LayoutProps = React.PropsWithChildren<{
  user: schemas.User;
  devices: schemas.Device[];
  selectedDevice?: schemas.Device;
}>;

const useUtilities = (user?: schemas.User): TopNavigationProps.Utility[] => {
  if (user) {
    return [
      {
        type: "menu-dropdown",
        text: user.name,
        description: user.email,
        iconName: "user-profile",
        items: [{ id: "signout", text: "Sign out", href: "#/signout" }],
      },
    ];
  }

  return [];
};

export function Layout({
  user,
  devices,
  selectedDevice,
  children,
}: LayoutProps) {
  const [showSplitPanel, setShowSplitPanel] = React.useState(true);
  const [showTools, setShowTools] = React.useState(false);
  const [showNavigation, setShowNavigation] = React.useState(true);
  const utilities = useUtilities(user);

  return (
    <I18nProvider locale={LOCALE} messages={[messages]}>
      <TopNavigation
        identity={{ href: "#", title: "Device Management" }}
        utilities={utilities}
      />
      <AppLayout
        navigationOpen={showNavigation}
        onNavigationChange={() => {
          setShowNavigation((prev) => !prev);
        }}
        navigation={<SideBar devices={devices} />}
        notifications={<Flashbar items={[]} />}
        toolsOpen={showTools}
        onToolsChange={() => {
          setShowTools((prev) => !prev);
        }}
        tools={
          <HelpPanel header={<Header variant="h2">Overview</Header>}>
            <Header variant="h3">
              Additional information about the selected device.
            </Header>
            <p>{selectedDevice?.description}</p>
          </HelpPanel>
        }
        content={children}
        contentType="default"
        onSplitPanelToggle={() => {
          setShowSplitPanel((prev) => !prev);
        }}
        splitPanelOpen={showSplitPanel}
        splitPanel={selectedDevice && (
          <OperationsPanel device={selectedDevice} />
        )}
      />
    </I18nProvider>
  );
}
