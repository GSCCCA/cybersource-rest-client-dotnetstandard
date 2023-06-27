/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;
using CyberSource.Utilities.Tracking;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReversalApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>PtsV2PaymentsReversalsPost201Response</returns>
        PtsV2PaymentsReversalsPost201Response AuthReversal (string id, AuthReversalRequest authReversalRequest);

        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsReversalsPost201Response</returns>
        ApiResponse<PtsV2PaymentsReversalsPost201Response> AuthReversalWithHttpInfo (string id, AuthReversalRequest authReversalRequest);
        /// <summary>
        /// Timeout Reversal
        /// </summary>
        /// <remarks>
        /// This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>PtsV2PaymentsReversalsPost201Response</returns>
        PtsV2PaymentsReversalsPost201Response MitReversal (MitReversalRequest mitReversalRequest);

        /// <summary>
        /// Timeout Reversal
        /// </summary>
        /// <remarks>
        /// This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsReversalsPost201Response</returns>
        ApiResponse<PtsV2PaymentsReversalsPost201Response> MitReversalWithHttpInfo (MitReversalRequest mitReversalRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of PtsV2PaymentsReversalsPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsReversalsPost201Response> AuthReversalAsync (string id, AuthReversalRequest authReversalRequest);

        /// <summary>
        /// Process an Authorization Reversal
        /// </summary>
        /// <remarks>
        /// Include the payment ID in the POST request to reverse the payment amount.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsReversalsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsReversalsPost201Response>> AuthReversalAsyncWithHttpInfo (string id, AuthReversalRequest authReversalRequest);
        /// <summary>
        /// Timeout Reversal
        /// </summary>
        /// <remarks>
        /// This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>Task of PtsV2PaymentsReversalsPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsReversalsPost201Response> MitReversalAsync (MitReversalRequest mitReversalRequest);

        /// <summary>
        /// Timeout Reversal
        /// </summary>
        /// <remarks>
        /// This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsReversalsPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsReversalsPost201Response>> MitReversalAsyncWithHttpInfo (MitReversalRequest mitReversalRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReversalApi : IReversalApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReversalApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReversalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReversalApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode == null ? 0 : (int) this._statusCode;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>PtsV2PaymentsReversalsPost201Response</returns>
        public PtsV2PaymentsReversalsPost201Response AuthReversal (string id, AuthReversalRequest authReversalRequest)
        {
            logger.Debug("CALLING API \"AuthReversal\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsReversalsPost201Response> localVarResponse = AuthReversalWithHttpInfo(id, authReversalRequest);
            logger.Debug("CALLING API \"AuthReversal\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsReversalsPost201Response</returns>
        public ApiResponse< PtsV2PaymentsReversalsPost201Response > AuthReversalWithHttpInfo (string id, AuthReversalRequest authReversalRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling ReversalApi->AuthReversal");
                throw new ApiException(400, "Missing required parameter 'id' when calling ReversalApi->AuthReversal");
            }
            // verify the required parameter 'authReversalRequest' is set
            if (authReversalRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'authReversalRequest' when calling ReversalApi->AuthReversal");
                throw new ApiException(400, "Missing required parameter 'authReversalRequest' when calling ReversalApi->AuthReversal");
            }

            var localVarPath = $"/pts/v2/payments/{id}/reversals";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (authReversalRequest != null && authReversalRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                authReversalRequest = (AuthReversalRequest)sdkTracker.InsertDeveloperIdTracker(authReversalRequest, authReversalRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(authReversalRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authReversalRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthReversal", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsReversalsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsReversalsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsReversalsPost201Response))); // Return statement
        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of PtsV2PaymentsReversalsPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsReversalsPost201Response> AuthReversalAsync (string id, AuthReversalRequest authReversalRequest)
        {
            logger.Debug("CALLING API \"AuthReversalAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsReversalsPost201Response> localVarResponse = await AuthReversalAsyncWithHttpInfo(id, authReversalRequest);
            logger.Debug("CALLING API \"AuthReversalAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Process an Authorization Reversal Include the payment ID in the POST request to reverse the payment amount.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The payment ID returned from a previous payment request.</param>
        /// <param name="authReversalRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsReversalsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsReversalsPost201Response>> AuthReversalAsyncWithHttpInfo (string id, AuthReversalRequest authReversalRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling ReversalApi->AuthReversal");
                throw new ApiException(400, "Missing required parameter 'id' when calling ReversalApi->AuthReversal");
            }
            // verify the required parameter 'authReversalRequest' is set
            if (authReversalRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'authReversalRequest' when calling ReversalApi->AuthReversal");
                throw new ApiException(400, "Missing required parameter 'authReversalRequest' when calling ReversalApi->AuthReversal");
            }

            var localVarPath = $"/pts/v2/payments/{id}/reversals";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (authReversalRequest != null && authReversalRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                authReversalRequest = (AuthReversalRequest)sdkTracker.InsertDeveloperIdTracker(authReversalRequest, authReversalRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(authReversalRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = authReversalRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthReversal", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsReversalsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsReversalsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsReversalsPost201Response))); // Return statement
        }
        /// <summary>
        /// Timeout Reversal This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>PtsV2PaymentsReversalsPost201Response</returns>
        public PtsV2PaymentsReversalsPost201Response MitReversal (MitReversalRequest mitReversalRequest)
        {
            logger.Debug("CALLING API \"MitReversal\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsReversalsPost201Response> localVarResponse = MitReversalWithHttpInfo(mitReversalRequest);
            logger.Debug("CALLING API \"MitReversal\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Timeout Reversal This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>ApiResponse of PtsV2PaymentsReversalsPost201Response</returns>
        public ApiResponse< PtsV2PaymentsReversalsPost201Response > MitReversalWithHttpInfo (MitReversalRequest mitReversalRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'mitReversalRequest' is set
            if (mitReversalRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'mitReversalRequest' when calling ReversalApi->MitReversal");
                throw new ApiException(400, "Missing required parameter 'mitReversalRequest' when calling ReversalApi->MitReversal");
            }

            var localVarPath = $"/pts/v2/reversals";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (mitReversalRequest != null && mitReversalRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                mitReversalRequest = (MitReversalRequest)sdkTracker.InsertDeveloperIdTracker(mitReversalRequest, mitReversalRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(mitReversalRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mitReversalRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MitReversal", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsReversalsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsReversalsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsReversalsPost201Response))); // Return statement
        }

        /// <summary>
        /// Timeout Reversal This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>Task of PtsV2PaymentsReversalsPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsReversalsPost201Response> MitReversalAsync (MitReversalRequest mitReversalRequest)
        {
            logger.Debug("CALLING API \"MitReversalAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsReversalsPost201Response> localVarResponse = await MitReversalAsyncWithHttpInfo(mitReversalRequest);
            logger.Debug("CALLING API \"MitReversalAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Timeout Reversal This is to reverse a previous payment that merchant does not receive a reply(Mostly due to Timeout). To use this feature/API, make sure to pass unique value to field - clientReferenceInformation -&gt; transactionId in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call and use same transactionId in this API request payload to reverse the payment.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="mitReversalRequest"></param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsReversalsPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsReversalsPost201Response>> MitReversalAsyncWithHttpInfo (MitReversalRequest mitReversalRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'mitReversalRequest' is set
            if (mitReversalRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'mitReversalRequest' when calling ReversalApi->MitReversal");
                throw new ApiException(400, "Missing required parameter 'mitReversalRequest' when calling ReversalApi->MitReversal");
            }

            var localVarPath = $"/pts/v2/reversals";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (mitReversalRequest != null && mitReversalRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                mitReversalRequest = (MitReversalRequest)sdkTracker.InsertDeveloperIdTracker(mitReversalRequest, mitReversalRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(mitReversalRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mitReversalRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MitReversal", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsReversalsPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsReversalsPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsReversalsPost201Response))); // Return statement
        }
    }
}
