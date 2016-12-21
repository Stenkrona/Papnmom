public interface IView {

	IModel model { get; set; }
    IController controller { get; set; }
    void ReceiveUpdate();
}
