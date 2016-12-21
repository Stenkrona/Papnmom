using System.Collections.Generic;

public interface IModel {

    List<IView> listeners { get; set; }
    void RegisterListener(IView listener);
	
}
