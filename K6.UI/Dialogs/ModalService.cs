namespace K6.UI.Dialogs
{
    public class ModalService
    {
        public Task Show<TModal, TModel>(TModel model)
            where TModal : Modal<TModel>
        {
            return Task.CompletedTask;
        }

        public Task Hide<TModal, TModel>(TModel model)
            where TModal : Modal<TModel>
        {
            return Task.CompletedTask;
        }
    }
}