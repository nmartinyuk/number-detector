using number_detector.Middlewares;

namespace number_detector
{
    public static class TokenExtensions
    {
        public static IApplicationBuilder UseToken(this IApplicationBuilder builder, string pattern)
        {
            return builder.UseMiddleware<TokenMiddleware>(pattern);
        }
    }
}
