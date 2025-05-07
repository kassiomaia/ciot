import * as React from 'react'
import {createFileRoute, Navigate, Outlet, useMatchRoute, useRouter} from '@tanstack/react-router'
import {Layout} from "../components/Layout";
import {Device} from "../types";
import {TanStackRouterDevtools} from "@tanstack/react-router-devtools";

export const Route = createFileRoute('/')({
    component: _protectedIndex,
    loader: async ({context}) => {
        return {
            user: context.user,
            devices: await context.api.getDevices(),
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