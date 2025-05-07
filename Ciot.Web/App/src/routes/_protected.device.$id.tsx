import * as React from 'react'
import {createFileRoute, Outlet} from '@tanstack/react-router'
import {Layout} from "../components/Layout";
import {Device} from "../types";
import {TanStackRouterDevtools} from "@tanstack/react-router-devtools";
import {api} from "../config/client";

export const Route = createFileRoute('/_protected/')({
    component: _protectedIndex,
    loader: async ({context}) => {
        return {
            user: context.user,
            devices: await api.fetch('/devices', {
                method: 'GET',
                headers: {
                    'Content-Type': 'application/json'
                }
            })
        }
    },
})

function _protectedIndex() {
    const {devices, user} = Route.useLoaderData();

    return (
        <Layout
            user={user!}
            devices={devices as Device[]}
        >
            <Outlet/>
            <TanStackRouterDevtools/>
        </Layout>
    );
}