# APIMatic Core Library for C#

[![Version][nuget-version]][nuget-url]
[![Build][test-badge]][test-url]
[![Tests][test-badge]][test-url]
[![Lint][lint-badge]][lint-url]
[![Test Coverage][coverage-badge]][coverage-url]
[![Maintainability][maintainability-badge]][maintainability-url]
[![Licence][license-badge]][license-url]

## Introduction
This project contains core logic and the utilities for the APIMatic's C# SDK

## Prerequisites
.NET and .NET Core versions 2.0, 2.1, 2.2, 3.0, 3.1, 5.0, 6.0, and 7.0

## Important Classes
| Name                                                                                 | Description                                                           |
|--------------------------------------------------------------------------------------|-----------------------------------------------------------------------|
| [`AdditionalFormParams`](APIMatic.Core/Request/Parameters/AdditionalFormParams.cs)   | Used to add additional form params to a request                       |
| [`AdditionalHeaderParams`](APIMatic.Core/Request/Parameters/AdditionalHeaderParams.cs) | Used to add additional header params to a request                     |
| [`AdditionalQueryParams`](APIMatic.Core/Request/Parameters/AdditionalQueryParams.cs) | Used to add additional query params to a request                      |
| [`BodyParam`](APIMatic.Core/Request/Parameters/BodyParam.cs)                         | Body parameter class                                                  |
| [`FormParam`](APIMatic.Core/Request/Parameters/FormParam.cs)                         | Form parameter class                                                  |
| [`HeaderParam`](APIMatic.Core/Request/Parameters/HeaderParam.cs)                     | Header parameter class                                                |
| [`QueryParam`](APIMatic.Core/Request/Parameters/QueryParam.cs)                       | Query parameter class                                                 |
| [`TemplateParam`](APIMatic.Core/Request/Parameters/TemplateParam.cs)                 | Template parameter class                                              |
| [`RequestBuilder`](APIMatic.Core/Request/RequestBuilder.cs)                          | Used to instantiate a new Request object with the provided properties |
| [`ResponseHandler`](APIMatic.Core/Response/ResponseHandler.cs)                       | Used to handle and process the response from HttpClient               |
| [`ApiCall`](APIMatic.Core/ApiCall.cs)  | Deals with the execution of request created from RequestBuilder and processes the response through ResponseHandler  |
| [`GlobalConfiguration`](APIMatic.Core/GlobalConfiguration.cs)  | Carries the common configuration that will be applicable to all the ApiCalls                |


[nuget-url]: https://www.nuget.org/packages/APIMatic.Core
[nuget-version]: https://img.shields.io/nuget/v/APIMatic.Core
[nuget-downloads]: https://img.shields.io/nuget/dt/APIMatic.Core
[test-badge]: https://github.com/apimatic/core-lib-csharp/actions/workflows/test.yml/badge.svg
[test-url]: https://github.com/apimatic/core-lib-csharp/actions/workflows/test.yml
[lint-badge]: https://github.com/apimatic/core-lib-csharp/actions/workflows/test.yml/badge.svg
[lint-url]: https://github.com/apimatic/core-lib-csharp/actions/workflows/test.yml
[coverage-badge]: https://api.codeclimate.com/v1/badges/90aa03dca1ef28d9cef3/test_coverage
[coverage-url]: https://codeclimate.com/github/apimatic/core-lib-php/test_coverage
[maintainability-badge]: https://api.codeclimate.com/v1/badges/90aa03dca1ef28d9cef3/maintainability
[maintainability-url]: https://codeclimate.com/github/apimatic/core-lib-php/maintainability
[license-badge]: https://img.shields.io/badge/licence-APIMATIC-blue
[license-url]: LICENSE
