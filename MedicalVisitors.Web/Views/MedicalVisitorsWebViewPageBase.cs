using Abp.Web.Mvc.Views;

namespace MedicalVisitors.Web.Views
{
    public abstract class MedicalVisitorsWebViewPageBase : MedicalVisitorsWebViewPageBase<dynamic>
    {

    }

    public abstract class MedicalVisitorsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MedicalVisitorsWebViewPageBase()
        {
            LocalizationSourceName = MedicalVisitorsConsts.LocalizationSourceName;
        }
    }
}