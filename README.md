# ChatRoomDemo

**ChatRoomDemo** is a mini-project demonstrating real-time communication using **SignalR** in **.NET 8**. This application allows multiple clients to send messages to each other instantly through a shared chat hub.

## Overview

ChatRoomDemo leverages **SignalR** to showcase real-time communication in a .NET environment. Clients connect to a central hub, enabling them to:

- Broadcast messages to all connected clients.
- Receive updates instantly without the need for page refreshes.

This project serves as a foundational example for building real-time applications, such as:

- Multi-user collaborative tools (e.g., document editing).
- Real-time dashboards.
- Live chat systems and notifications.

## Features

1. **SignalR Hub**

   - A `ChatHub` class handles real-time communication by managing the sending and receiving of messages.
   - Implements SignalR's publish-subscribe pattern to enable seamless message broadcasting.

2. **Real-Time Updates**

   - Messages are instantly displayed across all connected clients.
   - Uses **WebSockets** as the default transport with automatic fallback to other protocols (e.g., Server-Sent Events or Long Polling).

3. **Simple Front-End**
   - A basic Razor Page provides a demonstration interface for sending and receiving messages.
   - Includes client-side JavaScript for SignalR integration and real-time message handling.
