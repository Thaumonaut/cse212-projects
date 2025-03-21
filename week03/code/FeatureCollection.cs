public class FeatureCollection
{
    public string type {get; set;}
    public Metadata metadata {get; set;}
    public Features[] features {get; set;}
    public Geometry geometry {get; set;}
    public string id {get; set;}
}

public class Features 
{
    public string type {get; set;}
    public FeaturesProperties properties {get; set;}
}

public class FeaturesProperties
{
    public float mag {get; set;}
    public string place {get; set;}
    public Nullable<float> time {get; set;}
    public Nullable<float> updated {get; set;}
    public string tz {get; set;}
    public string url {get; set;}
    public string details {get; set;}
    public Nullable<float> felt {get; set;}
    public Nullable<float> cdi {get; set;}
    public Nullable<float> mmi {get; set;}
    public string alert {get; set;}
    public string status {get; set;}
    public int tsunami {get; set;}
    public int sig {get; set;}
    public string net {get; set;}
    public string code {get; set;}
    public string ids {get; set;}
    public string sources {get; set;}
    public string types {get; set;}
    public Nullable<int> nst {get; set;}
    public Nullable<float> dmin {get; set;}
    public Nullable<float> rms {get; set;}
    public Nullable<float> gap {get; set;}
    public string magType {get; set;}
    public string type {get; set;}
    public string title {get; set;}
}

public class Geometry
{
    public string type {get; set;}
    public Tuple<float, float, float> coordinates {get; set;}
}

public class Metadata
{
    public Nullable<float> generated {get; set;}
    public string url {get; set;}
    public string title {get; set;}
    public int status {get; set;}
    public string api {get; set;}
    public int count {get; set;}
}