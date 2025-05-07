import * as React from 'react'
import { createFileRoute } from '@tanstack/react-router'

export const Route = createFileRoute('/_login')({
    component: Login,
})

function Login() {
    return (
        <div className="h-screen flex items-center justify-center bg-gray-100">
            <form className="bg-white rounded-lg shadow-xl w-1/2 p-6">
                <h2 className="text-2xl font-bold mb-4">Login</h2>
                <div className="mb-4">
                    <label className="block mb-2 text-sm font-medium text-gray-900">Email</label>
                    <input
                        type="email"
                        className="border border-gray-300 rounded-lg p-2 w-full"
                        placeholder="Enter your email"
                    />
                </div>
                <div className="mb-4">
                    <label className="block mb-2 text-sm font-medium text-gray-900">Password</label>
                    <input
                        type="password"
                        className="border border-gray-300 rounded-lg p-2 w-full"
                        placeholder="Enter your password"
                    />
                </div>
                <button className="bg-blue-500 text-white rounded-lg px-4 py-2 hover:bg-blue-600">
                    Login
                </button>
            </form>
        </div>
    )
}