## Slooce.NET - Getting Started

1. Create a new SlooceApi with your environments configuration.

    ```
    using Slooce.NET;
    ...
    var slooceApi = new SlooceApi(new SlooceConfig("slooceurl", "sloocepassword"));
    ```
1. Register a user(make sure the user number includes country code)

    ```
    var registerResponse = await api.RegisterUserAsync("15555555555", "yourkeyword");
    //check result
    Console.WriteLine($"Register response: {registerResponse.Result}");
    ```
1. Send a text

    ```
    var textResponse = await api.SendMtMessageAsync("15555555555", "yourkeyword", "Hellow world");
    //check result
    Console.WriteLine($"Text response: {textResponse.Result}");
    ```
1. Dispose the api when you are done with it.

    ```
    slooceApi.Dispose();
    ```

## Tips

The `SlooceApi` class uses a backing `HttpClient` for its web requests, so you should be using **one** `SlooceApi` throughout your application. The `SlooceApi` already takes care of [DNS refresh issues when caching an HttpClient](http://www.nimaara.com/2016/11/01/beware-of-the-net-httpclient/) as well.

The `SlooceApi` should generate minimum garbage and uses caching wherever possible.
