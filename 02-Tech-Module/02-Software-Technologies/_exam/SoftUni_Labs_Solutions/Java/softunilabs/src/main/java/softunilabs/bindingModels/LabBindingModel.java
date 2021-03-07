package softunilabs.bindingModels;

import javax.validation.constraints.NotNull;

public class LabBindingModel {

    private String Name;
    private Integer Capacity;
    private String Status;

    public LabBindingModel() {
    }

    public LabBindingModel(String name, Integer capacity, String status) {
        Name = name;
        Capacity = capacity;
        Status = status;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public Integer getCapacity() {
        return Capacity;
    }

    public void setCapacity(Integer capacity) {
        Capacity = capacity;
    }

    public String getStatus() {
        return Status;
    }

    public void setStatus(String status) {
        Status = status;
    }
}
