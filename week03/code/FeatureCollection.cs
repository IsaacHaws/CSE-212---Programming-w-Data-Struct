public class FeatureCollection {
    public string Type { get; set; }
    public Features[] Features { get; set; }

}

public class Features {
    public string Type { get; set; }
    public Properties Properties { get; set; }
}

public class Properties {    
    public double Mag { get; set; }
    public string Place { get; set; }
}



