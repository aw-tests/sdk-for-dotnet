
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appwrite.Models;
using Appwrite.Enums;

namespace Appwrite.Services
{
    public class Account : Service
    {
        public Account(Client client) : base(client)
        {
        }

        /// <summary>
        /// Get account
        /// <para>
        /// Get the currently logged in user.
        /// </para>
        /// </summary>
        public Task<Models.User> Get()
        {
            var apiPath = "/account";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update email
        /// <para>
        /// Update currently logged in user account email address. After changing user
        /// address, the user confirmation status will get reset. A new confirmation
        /// email is not sent automatically however you can use the send confirmation
        /// email endpoint again to send the confirmation email. For security measures,
        /// user password is required to complete this request.
        /// This endpoint can also be used to convert an anonymous account to a normal
        /// one, by passing an email address and a new password.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateEmail(string email, string password)
        {
            var apiPath = "/account/email";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "password", password }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List Identities
        /// <para>
        /// Get the list of identities for the currently logged in user.
        /// </para>
        /// </summary>
        public Task<Models.IdentityList> ListIdentities(string? queries = null)
        {
            var apiPath = "/account/identities";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.IdentityList Convert(Dictionary<string, object> it) =>
                Models.IdentityList.From(map: it);


            return _client.Call<Models.IdentityList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete Identity
        /// <para>
        /// Delete an identity by its unique ID.
        /// </para>
        /// </summary>
        public Task<object> DeleteIdentity(string identityId)
        {
            var apiPath = "/account/identities/{identityId}"
                .Replace("{identityId}", identityId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// List logs
        /// <para>
        /// Get the list of latest security activity logs for the currently logged in
        /// user. Each log returns user IP address, location and date and time of log.
        /// </para>
        /// </summary>
        public Task<Models.LogList> ListLogs(List<string>? queries = null)
        {
            var apiPath = "/account/logs";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "queries", queries }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.LogList Convert(Dictionary<string, object> it) =>
                Models.LogList.From(map: it);


            return _client.Call<Models.LogList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update name
        /// <para>
        /// Update currently logged in user account name.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateName(string name)
        {
            var apiPath = "/account/name";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "name", name }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update password
        /// <para>
        /// Update currently logged in user password. For validation, user is required
        /// to pass in the new password, and the old password. For users created with
        /// OAuth, Team Invites and Magic URL, oldPassword is optional.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePassword(string password, string? oldPassword = null)
        {
            var apiPath = "/account/password";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "password", password },
                { "oldPassword", oldPassword }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update phone
        /// <para>
        /// Update the currently logged in user's phone number. After updating the
        /// phone number, the phone verification status will be reset. A confirmation
        /// SMS is not sent automatically, however you can use the [POST
        /// /account/verification/phone](https://appwrite.io/docs/references/cloud/client-web/account#createPhoneVerification)
        /// endpoint to send a confirmation SMS.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePhone(string phone, string password)
        {
            var apiPath = "/account/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "phone", phone },
                { "password", password }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Get account preferences
        /// <para>
        /// Get the preferences as a key-value object for the currently logged in user.
        /// </para>
        /// </summary>
        public Task<Models.Preferences> GetPrefs()
        {
            var apiPath = "/account/prefs";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Preferences Convert(Dictionary<string, object> it) =>
                Models.Preferences.From(map: it);


            return _client.Call<Models.Preferences>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update preferences
        /// <para>
        /// Update currently logged in user account preferences. The object you pass is
        /// stored as is, and replaces any previous value. The maximum allowed prefs
        /// size is 64kB and throws error if exceeded.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdatePrefs(object prefs)
        {
            var apiPath = "/account/prefs";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "prefs", prefs }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create password recovery
        /// <para>
        /// Sends the user an email with a temporary secret key for password reset.
        /// When the user clicks the confirmation link he is redirected back to your
        /// app password reset URL with the secret key and email address values
        /// attached to the URL query string. Use the query string params to submit a
        /// request to the [PUT
        /// /account/recovery](https://appwrite.io/docs/references/cloud/client-web/account#updateRecovery)
        /// endpoint to complete the process. The verification link sent to the user's
        /// email address is valid for 1 hour.
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateRecovery(string email, string url)
        {
            var apiPath = "/account/recovery";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "email", email },
                { "url", url }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create password recovery (confirmation)
        /// <para>
        /// Use this endpoint to complete the user account password reset. Both the
        /// **userId** and **secret** arguments will be passed as query parameters to
        /// the redirect URL you have provided when sending your request to the [POST
        /// /account/recovery](https://appwrite.io/docs/references/cloud/client-web/account#createRecovery)
        /// endpoint.
        /// 
        /// Please note that in order to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md)
        /// the only valid redirect URLs are the ones from domains you have set when
        /// adding your platforms in the console interface.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdateRecovery(string userId, string secret, string password, string passwordAgain)
        {
            var apiPath = "/account/recovery";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret },
                { "password", password },
                { "passwordAgain", passwordAgain }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// List sessions
        /// <para>
        /// Get the list of active sessions across different devices for the currently
        /// logged in user.
        /// </para>
        /// </summary>
        public Task<Models.SessionList> ListSessions()
        {
            var apiPath = "/account/sessions";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.SessionList Convert(Dictionary<string, object> it) =>
                Models.SessionList.From(map: it);


            return _client.Call<Models.SessionList>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete sessions
        /// <para>
        /// Delete all sessions from the user account and remove any sessions cookies
        /// from the end client.
        /// </para>
        /// </summary>
        public Task<object> DeleteSessions()
        {
            var apiPath = "/account/sessions";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Get session
        /// <para>
        /// Use this endpoint to get a logged in user's session using a Session ID.
        /// Inputting 'current' will return the current session being used.
        /// </para>
        /// </summary>
        public Task<Models.Session> GetSession(string sessionId)
        {
            var apiPath = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);


            return _client.Call<Models.Session>(
                method: "GET",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Update OAuth session (refresh tokens)
        /// <para>
        /// Access tokens have limited lifespan and expire to mitigate security risks.
        /// If session was created using an OAuth provider, this route can be used to
        /// "refresh" the access token.
        /// </para>
        /// </summary>
        public Task<Models.Session> UpdateSession(string sessionId)
        {
            var apiPath = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Session Convert(Dictionary<string, object> it) =>
                Models.Session.From(map: it);


            return _client.Call<Models.Session>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Delete session
        /// <para>
        /// Logout the user. Use 'current' as the session ID to logout on this device,
        /// use a session ID to logout on another device. If you're looking to logout
        /// the user on all devices, use [Delete
        /// Sessions](https://appwrite.io/docs/references/cloud/client-web/account#deleteSessions)
        /// instead.
        /// </para>
        /// </summary>
        public Task<object> DeleteSession(string sessionId)
        {
            var apiPath = "/account/sessions/{sessionId}"
                .Replace("{sessionId}", sessionId);

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };





            return _client.Call<object>(
                method: "DELETE",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!);

        }

        /// <summary>
        /// Update status
        /// <para>
        /// Block the currently logged in user account. Behind the scene, the user
        /// record is not deleted but permanently blocked from any access. To
        /// completely delete a user, use the Users API instead.
        /// </para>
        /// </summary>
        public Task<Models.User> UpdateStatus()
        {
            var apiPath = "/account/status";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.User Convert(Dictionary<string, object> it) =>
                Models.User.From(map: it);


            return _client.Call<Models.User>(
                method: "PATCH",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create email verification
        /// <para>
        /// Use this endpoint to send a verification message to your user email address
        /// to confirm they are the valid owners of that address. Both the **userId**
        /// and **secret** arguments will be passed as query parameters to the URL you
        /// have provided to be attached to the verification email. The provided URL
        /// should redirect the user back to your app and allow you to complete the
        /// verification process by verifying both the **userId** and **secret**
        /// parameters. Learn more about how to [complete the verification
        /// process](https://appwrite.io/docs/references/cloud/client-web/account#updateVerification).
        /// The verification link sent to the user's email address is valid for 7 days.
        /// 
        /// Please note that in order to avoid a [Redirect
        /// Attack](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/Unvalidated_Redirects_and_Forwards_Cheat_Sheet.md),
        /// the only valid redirect URLs are the ones from domains you have set when
        /// adding your platforms in the console interface.
        /// 
        /// </para>
        /// </summary>
        public Task<Models.Token> CreateVerification(string url)
        {
            var apiPath = "/account/verification";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "url", url }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create email verification (confirmation)
        /// <para>
        /// Use this endpoint to complete the user email verification process. Use both
        /// the **userId** and **secret** parameters that were attached to your app URL
        /// to verify the user email ownership. If confirmed this route will return a
        /// 200 status code.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdateVerification(string userId, string secret)
        {
            var apiPath = "/account/verification";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create phone verification
        /// <para>
        /// Use this endpoint to send a verification SMS to the currently logged in
        /// user. This endpoint is meant for use after updating a user's phone number
        /// using the
        /// [accountUpdatePhone](https://appwrite.io/docs/references/cloud/client-web/account#updatePhone)
        /// endpoint. Learn more about how to [complete the verification
        /// process](https://appwrite.io/docs/references/cloud/client-web/account#updatePhoneVerification).
        /// The verification code sent to the user's phone number is valid for 15
        /// minutes.
        /// </para>
        /// </summary>
        public Task<Models.Token> CreatePhoneVerification()
        {
            var apiPath = "/account/verification/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "POST",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

        /// <summary>
        /// Create phone verification (confirmation)
        /// <para>
        /// Use this endpoint to complete the user phone verification process. Use the
        /// **userId** and **secret** that were sent to your user's phone number to
        /// verify the user email ownership. If confirmed this route will return a 200
        /// status code.
        /// </para>
        /// </summary>
        public Task<Models.Token> UpdatePhoneVerification(string userId, string secret)
        {
            var apiPath = "/account/verification/phone";

            var apiParameters = new Dictionary<string, object?>()
            {
                { "userId", userId },
                { "secret", secret }
            };

            var apiHeaders = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };



            static Models.Token Convert(Dictionary<string, object> it) =>
                Models.Token.From(map: it);


            return _client.Call<Models.Token>(
                method: "PUT",
                path: apiPath,
                headers: apiHeaders,
                parameters: apiParameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: Convert);

        }

    }
}
