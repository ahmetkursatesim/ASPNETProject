using Abp.Web.Mvc.Views;

namespace Myproject.Web.Views
{
    public abstract class MyprojectWebViewPageBase : MyprojectWebViewPageBase<dynamic>
    {

    }

    public abstract class MyprojectWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyprojectWebViewPageBase()
        {
            LocalizationSourceName = MyprojectConsts.LocalizationSourceName;
        }
    }
}