# FPL.net

[![Build Status](https://dev.azure.com/techtoniq/FPL.net/_apis/build/status/techtoniq.FPL.net?branchName=main)](https://dev.azure.com/techtoniq/FPL.net/_build/latest?definitionId=72&branchName=main)  [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Techtoniq_FPL.net&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=Techtoniq_FPL.net)

A lightweight .net wrapper for the Fantasy Premier League API.

.Net version 6.0

## Example

```c#

using FPL.Api;
using FPL.Api.Responses;
using System.Threading.Tasks;

...

var apiClient = new ApiClient();                
var response = await apiClient.GetStaticAsync();

Console.WriteLine(response.Teams[0].Name);
```

## Endpoint Documentation

https://medium.com/@frenzelts/fantasy-premier-league-api-endpoints-a-detailed-guide-acbd5598eb19


## Endpoints Covered

1. General Information
https://fantasy.premierleague.com/api/bootstrap-static/

2. Fixtures
https://fantasy.premierleague.com/api/fixtures/

3. Players' Detailed Data
https://fantasy.premierleague.com/api/element-summary/{element_id}/


## Endpoints To Be Covered

4. Gameweek Live Data
Full URL: https://fantasy.premierleague.com/api/event/{event_id}/live/

5. Manager/User Basic Information
https://fantasy.premierleague.com/api/entry/{manager_id}/

6. Manager/Users' History
https://fantasy.premierleague.com/api/entry/{manager_id}/history/

7. Classic League Standings
https://fantasy.premierleague.com/api/leagues-classic/{league_id}/standings

8. My Team (requires authentication)
https://fantasy.premierleague.com/api/my-team/{manager_id}/

9. Manager/Users' Team Per Gameweek
https://fantasy.premierleague.com/api/entry/{manager_id}/event/{event_id}/picks/

10. Event Status
https://fantasy.premierleague.com/api/event-status/

11. Dream Team
https://fantasy.premierleague.com/api/dream-team/{event_id}/

12. Set Piece Taker Notes
https://fantasy.premierleague.com/api/team/set-piece-notes/


## Notes

The API returns decimal numbers as strings in the json stream. Therefore the models have string fields to hold these values. 
Ideally we should customize the json deserialization to process these fields as nullable decimals `decimal?`.