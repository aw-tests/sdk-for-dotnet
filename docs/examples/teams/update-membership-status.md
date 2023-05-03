using Appwrite;
using Appwrite.Models;

Client client = new Client()
    .SetEndPoint("https://[HOSTNAME_OR_IP]/v1") // Your API Endpoint
    .SetProject("5df5acd0d48c2") // Your project ID
    .SetJWT("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ..."); // Your secret JSON Web Token

Teams teams = new Teams(client);

Membership result = await teams.UpdateMembershipStatus(
    teamId: "[TEAM_ID]",
    membershipId: "[MEMBERSHIP_ID]",
    userId: "[USER_ID]",
    secret: "[SECRET]");