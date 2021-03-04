// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Http.Headers
{
    internal static class QPackStaticTable
    {
        // https://tools.ietf.org/html/draft-ietf-quic-qpack-11#appendix-A
        // TODO: can we put some of this logic into H3StaticTable and/or generate it using data that is already there?
        internal static (HeaderDescriptor descriptor, string value)[] HeaderLookup { get; } = new (HeaderDescriptor descriptor, string value)[]
        {
            (new HeaderDescriptor(":authority"), ""),
            (new HeaderDescriptor(":path"), "/"),
            (new HeaderDescriptor(KnownHeaders.Age), "0"),
            (new HeaderDescriptor(KnownHeaders.ContentDisposition), ""),
            (new HeaderDescriptor(KnownHeaders.ContentLength), "0"),
            (new HeaderDescriptor(KnownHeaders.Date), ""),
            (new HeaderDescriptor(KnownHeaders.ETag), ""),
            (new HeaderDescriptor(KnownHeaders.IfModifiedSince), ""),
            (new HeaderDescriptor(KnownHeaders.IfNoneMatch), ""),
            (new HeaderDescriptor(KnownHeaders.LastModified), ""),
            (new HeaderDescriptor(KnownHeaders.Link), ""),
            (new HeaderDescriptor(KnownHeaders.Location), ""),
            (new HeaderDescriptor(KnownHeaders.Referer), ""),
            (new HeaderDescriptor(KnownHeaders.SetCookie), ""),
            (new HeaderDescriptor(":method"), "CONNECT"),
            (new HeaderDescriptor(":method"), "DELETE"),
            (new HeaderDescriptor(":method"), "GET"),
            (new HeaderDescriptor(":method"), "HEAD"),
            (new HeaderDescriptor(":method"), "OPTIONS"),
            (new HeaderDescriptor(":method"), "POST"),
            (new HeaderDescriptor(":method"), "PUT"),
            (new HeaderDescriptor(":scheme"), "http"),
            (new HeaderDescriptor(":scheme"), "https"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "103"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "200"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "304"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "404"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "503"),
            (new HeaderDescriptor(KnownHeaders.Accept), "*/*"),
            (new HeaderDescriptor(KnownHeaders.Accept), "application/dns-message"),
            (new HeaderDescriptor(KnownHeaders.AcceptEncoding), "gzip, deflate, br"),
            (new HeaderDescriptor(KnownHeaders.AcceptRanges), "bytes"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowHeaders), "cache-control"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowHeaders), "content-type"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowHeaders), "*"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowOrigin), "*"),
            (new HeaderDescriptor(KnownHeaders.CacheControl), "max-age=0"),
            (new HeaderDescriptor(KnownHeaders.CacheControl), "max-age=2592000"),
            (new HeaderDescriptor(KnownHeaders.CacheControl), "max-age=604800"),
            (new HeaderDescriptor(KnownHeaders.CacheControl), "no-cache"),
            (new HeaderDescriptor(KnownHeaders.CacheControl), "no-store"),
            (new HeaderDescriptor(KnownHeaders.CacheControl), "public, max-age=31536000"),
            (new HeaderDescriptor(KnownHeaders.ContentEncoding), "br"),
            (new HeaderDescriptor(KnownHeaders.ContentEncoding), "gzip"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "application/dns-message"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "application/javascript"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "application/json"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "application/x-www-form-urlencoded"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "image/gif"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "image/jpeg"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "image/png"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "text/css"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "text/html; charset=utf-8"), // Whitespace is correct, see spec.
            (new HeaderDescriptor(KnownHeaders.ContentType), "text/plain"),
            (new HeaderDescriptor(KnownHeaders.ContentType), "text/plain;charset=utf-8"), // Whitespace is correct, see spec.
            (new HeaderDescriptor(KnownHeaders.Range), "bytes=0-"),
            (new HeaderDescriptor(KnownHeaders.StrictTransportSecurity), "max-age=31536000"),
            (new HeaderDescriptor(KnownHeaders.StrictTransportSecurity), "max-age=31536000; includesubdomains"),
            (new HeaderDescriptor(KnownHeaders.StrictTransportSecurity), "max-age=31536000; includesubdomains; preload"),
            (new HeaderDescriptor(KnownHeaders.Vary), "accept-encoding"),
            (new HeaderDescriptor(KnownHeaders.Vary), "origin"),
            (new HeaderDescriptor(KnownHeaders.XContentTypeOptions), "nosniff"),
            (new HeaderDescriptor("x-xss-protection"), "1; mode=block"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "100"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "204"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "206"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "302"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "400"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "403"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "421"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "425"),
            (new HeaderDescriptor(KnownHeaders.PseudoStatus), "500"),
            (new HeaderDescriptor(KnownHeaders.AcceptLanguage), ""),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowCredentials), "FALSE"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowCredentials), "TRUE"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowHeaders), "*"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowMethods), "get"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowMethods), "get, post, options"),
            (new HeaderDescriptor(KnownHeaders.AccessControlAllowMethods), "options"),
            (new HeaderDescriptor(KnownHeaders.AccessControlExposeHeaders), "content-length"),
            (new HeaderDescriptor("access-control-request-headers"), "content-type"),
            (new HeaderDescriptor("access-control-request-method"), "get"),
            (new HeaderDescriptor("access-control-request-method"), "post"),
            (new HeaderDescriptor(KnownHeaders.AltSvc), "clear"),
            (new HeaderDescriptor(KnownHeaders.Authorization), ""),
            (new HeaderDescriptor(KnownHeaders.ContentSecurityPolicy), "script-src 'none'; object-src 'none'; base-uri 'none'"),
            (new HeaderDescriptor("early-data"), "1"),
            (new HeaderDescriptor("expect-ct"), ""),
            (new HeaderDescriptor("forwarded"), ""),
            (new HeaderDescriptor(KnownHeaders.IfRange), ""),
            (new HeaderDescriptor(KnownHeaders.Origin), ""),
            (new HeaderDescriptor("purpose"), "prefetch"),
            (new HeaderDescriptor(KnownHeaders.Server), ""),
            (new HeaderDescriptor("timing-allow-origin"), "*"),
            (new HeaderDescriptor(KnownHeaders.UpgradeInsecureRequests), "1"),
            (new HeaderDescriptor(KnownHeaders.UserAgent), ""),
            (new HeaderDescriptor("x-forwarded-for"), ""),
            (new HeaderDescriptor(KnownHeaders.XFrameOptions), "deny"),
            (new HeaderDescriptor(KnownHeaders.XFrameOptions), "sameorigin")
        };
    }
}
