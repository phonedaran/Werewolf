/* 
 * Werewolf Engine
 *
 * This is a werewolf game engine for REST access. It is primarily developed for CPE200 class at Computer Engineering, Chiang Mai University.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: pruetboonma@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using WerewolfAPI.Client;
using WerewolfAPI.Model;
using Action = WerewolfAPI.Model.Action;

namespace WerewolfAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IActionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get list of actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Action&gt;</returns>
        List<Action> ActionGet ();

        /// <summary>
        /// Get list of actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Action&gt;</returns>
        ApiResponse<List<Action>> ActionGetWithHttpInfo ();
        /// <summary>
        /// Finds actions by roleId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>List&lt;Action&gt;</returns>
        List<Action> FindActionsByRoleId (long? roleId);

        /// <summary>
        /// Finds actions by roleId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>ApiResponse of List&lt;Action&gt;</returns>
        ApiResponse<List<Action>> FindActionsByRoleIdWithHttpInfo (long? roleId);
        /// <summary>
        /// Find action by ID
        /// </summary>
        /// <remarks>
        /// Returns a single action
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>Action</returns>
        Action GetActionById (long? actionID);

        /// <summary>
        /// Find action by ID
        /// </summary>
        /// <remarks>
        /// Returns a single action
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>ApiResponse of Action</returns>
        ApiResponse<Action> GetActionByIdWithHttpInfo (long? actionID);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get list of actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Action&gt;</returns>
        System.Threading.Tasks.Task<List<Action>> ActionGetAsync ();

        /// <summary>
        /// Get list of actions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Action&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Action>>> ActionGetAsyncWithHttpInfo ();
        /// <summary>
        /// Finds actions by roleId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>Task of List&lt;Action&gt;</returns>
        System.Threading.Tasks.Task<List<Action>> FindActionsByRoleIdAsync (long? roleId);

        /// <summary>
        /// Finds actions by roleId
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>Task of ApiResponse (List&lt;Action&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Action>>> FindActionsByRoleIdAsyncWithHttpInfo (long? roleId);
        /// <summary>
        /// Find action by ID
        /// </summary>
        /// <remarks>
        /// Returns a single action
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>Task of Action</returns>
        System.Threading.Tasks.Task<Action> GetActionByIdAsync (long? actionID);

        /// <summary>
        /// Find action by ID
        /// </summary>
        /// <remarks>
        /// Returns a single action
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>Task of ApiResponse (Action)</returns>
        System.Threading.Tasks.Task<ApiResponse<Action>> GetActionByIdAsyncWithHttpInfo (long? actionID);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ActionApi : IActionApi
    {
        private WerewolfAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = WerewolfAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ActionApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = WerewolfAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public WerewolfAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get list of actions 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;Action&gt;</returns>
        public List<Action> ActionGet ()
        {
             ApiResponse<List<Action>> localVarResponse = ActionGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get list of actions 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;Action&gt;</returns>
        public ApiResponse< List<Action> > ActionGetWithHttpInfo ()
        {

            var localVarPath = "/action";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActionGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Action>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Action>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Action>)));
        }

        /// <summary>
        /// Get list of actions 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;Action&gt;</returns>
        public async System.Threading.Tasks.Task<List<Action>> ActionGetAsync ()
        {
             ApiResponse<List<Action>> localVarResponse = await ActionGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get list of actions 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;Action&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Action>>> ActionGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/action";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ActionGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Action>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Action>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Action>)));
        }

        /// <summary>
        /// Finds actions by roleId 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>List&lt;Action&gt;</returns>
        public List<Action> FindActionsByRoleId (long? roleId)
        {
             ApiResponse<List<Action>> localVarResponse = FindActionsByRoleIdWithHttpInfo(roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Finds actions by roleId 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>ApiResponse of List&lt;Action&gt;</returns>
        public ApiResponse< List<Action> > FindActionsByRoleIdWithHttpInfo (long? roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling ActionApi->FindActionsByRoleId");

            var localVarPath = "/action/findByRole/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindActionsByRoleId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Action>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Action>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Action>)));
        }

        /// <summary>
        /// Finds actions by roleId 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>Task of List&lt;Action&gt;</returns>
        public async System.Threading.Tasks.Task<List<Action>> FindActionsByRoleIdAsync (long? roleId)
        {
             ApiResponse<List<Action>> localVarResponse = await FindActionsByRoleIdAsyncWithHttpInfo(roleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Finds actions by roleId 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="roleId">Role Id to find actions</param>
        /// <returns>Task of ApiResponse (List&lt;Action&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Action>>> FindActionsByRoleIdAsyncWithHttpInfo (long? roleId)
        {
            // verify the required parameter 'roleId' is set
            if (roleId == null)
                throw new ApiException(400, "Missing required parameter 'roleId' when calling ActionApi->FindActionsByRoleId");

            var localVarPath = "/action/findByRole/{roleId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (roleId != null) localVarPathParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindActionsByRoleId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Action>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Action>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Action>)));
        }

        /// <summary>
        /// Find action by ID Returns a single action
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>Action</returns>
        public Action GetActionById (long? actionID)
        {
             ApiResponse<Action> localVarResponse = GetActionByIdWithHttpInfo(actionID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find action by ID Returns a single action
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>ApiResponse of Action</returns>
        public ApiResponse< Action > GetActionByIdWithHttpInfo (long? actionID)
        {
            // verify the required parameter 'actionID' is set
            if (actionID == null)
                throw new ApiException(400, "Missing required parameter 'actionID' when calling ActionApi->GetActionById");

            var localVarPath = "/action/{actionID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (actionID != null) localVarPathParams.Add("actionID", Configuration.ApiClient.ParameterToString(actionID)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetActionById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Action>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Action)));
        }

        /// <summary>
        /// Find action by ID Returns a single action
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>Task of Action</returns>
        public async System.Threading.Tasks.Task<Action> GetActionByIdAsync (long? actionID)
        {
             ApiResponse<Action> localVarResponse = await GetActionByIdAsyncWithHttpInfo(actionID);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find action by ID Returns a single action
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="actionID">ID of action to return</param>
        /// <returns>Task of ApiResponse (Action)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Action>> GetActionByIdAsyncWithHttpInfo (long? actionID)
        {
            // verify the required parameter 'actionID' is set
            if (actionID == null)
                throw new ApiException(400, "Missing required parameter 'actionID' when calling ActionApi->GetActionById");

            var localVarPath = "/action/{actionID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (actionID != null) localVarPathParams.Add("actionID", Configuration.ApiClient.ParameterToString(actionID)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetActionById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Action>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Action) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Action)));
        }

    }
}
