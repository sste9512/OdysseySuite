export type Result<T, E = Error> =
    | { ok: true; value: T }
    | { ok: false; error: E };

// Example Usage ->
//
// async get(channelId: ChannelId): Promise<Result<Channel>> {
//     try {
//         const channel = await container.resolve<IChannelClient>("IChannelClient").get(channelId);
//         return { ok: true, value: channel };
//     } catch (error) {
//         console.error("Error fetching channel:", error);
//         return { ok: false, error: error as Error };
//     }
// },