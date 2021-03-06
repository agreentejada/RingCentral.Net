using System.Threading.Tasks;

namespace RingCentral.Paths.Restapi.Glip.Teams.Unarchive
{
    public partial class Index
    {
        public RestClient rc;
        public Restapi.Glip.Teams.Index parent;

        public Index(Restapi.Glip.Teams.Index parent)
        {
            this.parent = parent;
            this.rc = parent.rc;
        }

        public string Path()
        {
            return $"{parent.Path()}/unarchive";
        }

        /// <summary>
        /// Operation: Unarchive Team
        /// HTTP Method: POST
        /// Endpoint: /restapi/v1.0/glip/teams/{chatId}/unarchive
        /// Rate Limit Group: Medium
        /// App Permission: Glip
        /// User Permission: Glip
        /// </summary>
        public async Task<string> Post(RestRequestConfig restRequestConfig = null)
        {
            return await rc.Post<string>(this.Path(), null, restRequestConfig);
        }
    }
}

namespace RingCentral.Paths.Restapi.Glip.Teams
{
    public partial class Index
    {
        public Restapi.Glip.Teams.Unarchive.Index Unarchive()
        {
            return new Restapi.Glip.Teams.Unarchive.Index(this);
        }
    }
}