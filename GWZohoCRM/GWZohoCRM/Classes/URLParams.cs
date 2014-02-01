using System;
using System.Collections.Generic;
using System.Text;

namespace GWZohoCRM.Classes
{
    class URLParams
    {
        private String crmurl  = Resource.Resource.CRMURL;
        private String accountsurl = Resource.Resource.AccountsURL;
        private String loginParam;
        private String param;
        private String serviceName = Resource.Resource.servicename;
        private String serviceParam;

        public String getCrmURL() { 
            return crmurl;
        }

        public void setCrmURL(String url) {
            this.crmurl = url;
        }

        public String getAccURL()
        {
            return accountsurl;
        }

        public void setAccURL(String url)
        {
            this.accountsurl = url;
        }

        public String getLoginParams()
        {
            return loginParam;
        }

        public void setLoginParams(String param)
        {
            this.loginParam = param;
        }
        public String getServiceParam() {
            return  "/apiauthtoken/nb/create?SCOPE=" + this.serviceName + "/crmapi";
        }

    }
}
