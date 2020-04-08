### Info

This demo repo shows that UWP apps cannot access localhost on its own. If you open the solution in VS2019, the solution is configured to launch the UWP app demo and an ASP.NET Core API project at the same time.

### Instructions

1. Clone repo.
2. Launch solution in VS 2019.
3. Press F5. This should launch the UWP project and the web project at the same time.
4. Your browser should launch with a URL similar to https://localhost:{portnumber}/weatherforecast. Copy the URL that launched in your browser.
5. Paste into the UWP app.
6. Click the Send GET request button.
7. Wait for a response. It should have failed.
8. Now stop debugging in VS2019.
9. Right click on the UWP project > click properties > Debug > enable the checkbox for "Allow local network loopback". Save and close the properties tab.
10. Repeat steps 3-6.
11. Now you will get real data back from localhost.
12. Thus, this demo shows that UWP cannot access localhost on its own.
