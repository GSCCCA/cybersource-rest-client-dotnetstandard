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

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKeyGenerationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>FlexV1KeysPost200Response</returns>
        FlexV1KeysPost200Response GeneratePublicKey (string format, GeneratePublicKeyRequest generatePublicKeyRequest);

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>ApiResponse of FlexV1KeysPost200Response</returns>
        ApiResponse<FlexV1KeysPost200Response> GeneratePublicKeyWithHttpInfo (string format, GeneratePublicKeyRequest generatePublicKeyRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>Task of FlexV1KeysPost200Response</returns>
        System.Threading.Tasks.Task<FlexV1KeysPost200Response> GeneratePublicKeyAsync (string format, GeneratePublicKeyRequest generatePublicKeyRequest);

        /// <summary>
        /// Generate Key
        /// </summary>
        /// <remarks>
        /// Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>Task of ApiResponse (FlexV1KeysPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FlexV1KeysPost200Response>> GeneratePublicKeyAsyncWithHttpInfo (string format, GeneratePublicKeyRequest generatePublicKeyRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KeyGenerationApi : IKeyGenerationApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyGenerationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KeyGenerationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="KeyGenerationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KeyGenerationApi(Configuration configuration = null)
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
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
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
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>FlexV1KeysPost200Response</returns>
        public FlexV1KeysPost200Response GeneratePublicKey (string format, GeneratePublicKeyRequest generatePublicKeyRequest)
        {
            logger.Debug("CALLING API \"GeneratePublicKey\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<FlexV1KeysPost200Response> localVarResponse = GeneratePublicKeyWithHttpInfo(format, generatePublicKeyRequest);
            logger.Debug("CALLING API \"GeneratePublicKey\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>ApiResponse of FlexV1KeysPost200Response</returns>
        public ApiResponse< FlexV1KeysPost200Response > GeneratePublicKeyWithHttpInfo (string format, GeneratePublicKeyRequest generatePublicKeyRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'format' is set
            if (format == null)
            {
                logger.Error("ApiException : Missing required parameter 'format' when calling KeyGenerationApi->GeneratePublicKey");
                throw new ApiException(400, "Missing required parameter 'format' when calling KeyGenerationApi->GeneratePublicKey");
            }
            // verify the required parameter 'generatePublicKeyRequest' is set
            if (generatePublicKeyRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'generatePublicKeyRequest' when calling KeyGenerationApi->GeneratePublicKey");
                throw new ApiException(400, "Missing required parameter 'generatePublicKeyRequest' when calling KeyGenerationApi->GeneratePublicKey");
            }

            var localVarPath = $"/flex/v1/keys";
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
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (format != null)
            {
                localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (generatePublicKeyRequest != null && generatePublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(generatePublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generatePublicKeyRequest; // byte array
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                ApiException exception = (ApiException) ExceptionFactory("GeneratePublicKey", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<FlexV1KeysPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlexV1KeysPost200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlexV1KeysPost200Response))); // Return statement
        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>Task of FlexV1KeysPost200Response</returns>
        public async System.Threading.Tasks.Task<FlexV1KeysPost200Response> GeneratePublicKeyAsync (string format, GeneratePublicKeyRequest generatePublicKeyRequest)
        {
            logger.Debug("CALLING API \"GeneratePublicKeyAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<FlexV1KeysPost200Response> localVarResponse = await GeneratePublicKeyAsyncWithHttpInfo(format, generatePublicKeyRequest);
            logger.Debug("CALLING API \"GeneratePublicKeyAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Generate Key Generate a one-time use public key and key ID to encrypt the card number in the follow-on Tokenize Card request. The key used to encrypt the card number on the cardholder’s device or browser is valid for 15 minutes and must be used to verify the signature in the response message. CyberSource recommends creating a new key for each order. Generating a key is an authenticated request initiated from your servers, prior to requesting to tokenize the card data from your customer’s device or browser.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">Indicator to enable the receipt of the Keys response in Flex 11+ format (JWT) or legacy (parameter not required)</param>
        /// <param name="generatePublicKeyRequest"></param>
        /// <returns>Task of ApiResponse (FlexV1KeysPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FlexV1KeysPost200Response>> GeneratePublicKeyAsyncWithHttpInfo (string format, GeneratePublicKeyRequest generatePublicKeyRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'format' is set
            if (format == null)
            {
                logger.Error("ApiException : Missing required parameter 'format' when calling KeyGenerationApi->GeneratePublicKey");
                throw new ApiException(400, "Missing required parameter 'format' when calling KeyGenerationApi->GeneratePublicKey");
            }
            // verify the required parameter 'generatePublicKeyRequest' is set
            if (generatePublicKeyRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'generatePublicKeyRequest' when calling KeyGenerationApi->GeneratePublicKey");
                throw new ApiException(400, "Missing required parameter 'generatePublicKeyRequest' when calling KeyGenerationApi->GeneratePublicKey");
            }

            var localVarPath = $"/flex/v1/keys";
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
                "application/json"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (format != null)
            {
                localVarQueryParams.Add("format", Configuration.ApiClient.ParameterToString(format)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (generatePublicKeyRequest != null && generatePublicKeyRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(generatePublicKeyRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = generatePublicKeyRequest; // byte array
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
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                ApiException exception = (ApiException) ExceptionFactory("GeneratePublicKey", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<FlexV1KeysPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FlexV1KeysPost200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FlexV1KeysPost200Response))); // Return statement
        }
    }
}
