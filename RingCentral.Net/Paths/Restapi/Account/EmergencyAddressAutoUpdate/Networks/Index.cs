using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate.Networks
{
    public partial class Index
    {
        public RestClient rc;
        public string networkId;
        public Restapi.Account.EmergencyAddressAutoUpdate.Index parent;

        public Index(Restapi.Account.EmergencyAddressAutoUpdate.Index parent, string networkId = null)
        {
            this.parent = parent;
            this.rc = parent.rc;
            this.networkId = networkId;
        }

        public string Path(bool withParameter = true)
        {
            if (withParameter && networkId != null)
            {
                return $"{parent.Path()}/networks/{networkId}";
            }

            return $"{parent.Path()}/networks";
        }

        /// <summary>
        /// Operation: Get Network Map
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworksList> List(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Get<RingCentral.NetworksList>(this.Path(false), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Create Network
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Post(RingCentral.CreateNetworkRequest createNetworkRequest,
            RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<RingCentral.NetworkInfo>(this.Path(false), createNetworkRequest, null,
                restRequestConfig);
        }

        /// <summary>
        /// Operation: Get Network
        /// HTTP Method: GET
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// Rate Limit Group: Medium
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<RingCentral.NetworkInfo> Get(RestRequestConfig restRequestConfig = null)
        {
            if (this.networkId == null)
            {
                throw new System.ArgumentNullException("networkId");
            }

            return await rc.Get<RingCentral.NetworkInfo>(this.Path(), null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Update Network
        /// HTTP Method: PUT
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Put(RingCentral.UpdateNetworkRequest updateNetworkRequest,
            RestRequestConfig restRequestConfig = null)
        {
            if (this.networkId == null)
            {
                throw new System.ArgumentNullException("networkId");
            }

            return await rc.Put<string>(this.Path(), updateNetworkRequest, null, restRequestConfig);
        }

        /// <summary>
        /// Operation: Delete Network
        /// HTTP Method: DELETE
        /// Endpoint: /restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}
        /// Rate Limit Group: Heavy
        /// App Permission: EditAccounts
        /// User Permission: ConfigureEmergencyMaps
        /// </summary>
        public async Task<string> Delete(RestRequestConfig restRequestConfig = null)
        {
            if (this.networkId == null)
            {
                throw new System.ArgumentNullException("networkId");
            }

            return await rc.Delete<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Account.EmergencyAddressAutoUpdate
{
    public partial class Index
    {
        public Restapi.Account.EmergencyAddressAutoUpdate.Networks.Index Networks(string networkId = null)
        {
            return new Restapi.Account.EmergencyAddressAutoUpdate.Networks.Index(this, networkId);
        }
    }
}