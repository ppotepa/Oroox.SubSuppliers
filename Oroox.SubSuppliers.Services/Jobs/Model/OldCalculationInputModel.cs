using Newtonsoft.Json;

namespace Oroox.SubSuppliers.Services.Jobs.Model
{
    public class OldCalculationInputModel
    {
        [JsonProperty("1")]
        public _1 _1 { get; set; }
        [JsonProperty("5")]
        public _5 _5 { get; set; }
        [JsonProperty("10")]
        public _10 _10 { get; set; }
        [JsonProperty("20")]
        public _20 _20 { get; set; }
        [JsonProperty("50")]
        public _50 _50 { get; set; }
        [JsonProperty("100")]
        public _100 _100 { get; set; }
    }

    public class _1
    {
        public Details Details { get; set; }
    }

    public class Details
    {
        public Part_0 part_0 { get; set; }
        public Part_1 part_1 { get; set; }
        public Part_2 part_2 { get; set; }
    }

    public class Part_0
    {
        public object Name { get; set; }
        public Section[] Sections { get; set; }
    }

    public class Section
    {
        public string Name { get; set; }
        public Detail[] Details { get; set; }
    }

    public class Detail
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_1
    {
        public object Name { get; set; }
        public Section1[] Sections { get; set; }
    }

    public class Section1
    {
        public string Name { get; set; }
        public Detail1[] Details { get; set; }
    }

    public class Detail1
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_2
    {
        public object Name { get; set; }
        public Section2[] Sections { get; set; }
    }

    public class Section2
    {
        public string Name { get; set; }
        public Detail2[] Details { get; set; }
    }

    public class Detail2
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class _5
    {
        public Details1 Details { get; set; }
    }

    public class Details1
    {
        public Part_01 part_0 { get; set; }
        public Part_11 part_1 { get; set; }
        public Part_21 part_2 { get; set; }
    }

    public class Part_01
    {
        public object Name { get; set; }
        public Section3[] Sections { get; set; }
    }

    public class Section3
    {
        public string Name { get; set; }
        public Detail3[] Details { get; set; }
    }

    public class Detail3
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_11
    {
        public object Name { get; set; }
        public Section4[] Sections { get; set; }
    }

    public class Section4
    {
        public string Name { get; set; }
        public Detail4[] Details { get; set; }
    }

    public class Detail4
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_21
    {
        public object Name { get; set; }
        public Section5[] Sections { get; set; }
    }

    public class Section5
    {
        public string Name { get; set; }
        public Detail5[] Details { get; set; }
    }

    public class Detail5
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class _10
    {
        public Details2 Details { get; set; }
    }

    public class Details2
    {
        public Part_02 part_0 { get; set; }
        public Part_12 part_1 { get; set; }
        public Part_22 part_2 { get; set; }
    }

    public class Part_02
    {
        public object Name { get; set; }
        public Section6[] Sections { get; set; }
    }

    public class Section6
    {
        public string Name { get; set; }
        public Detail6[] Details { get; set; }
    }

    public class Detail6
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_12
    {
        public object Name { get; set; }
        public Section7[] Sections { get; set; }
    }

    public class Section7
    {
        public string Name { get; set; }
        public Detail7[] Details { get; set; }
    }

    public class Detail7
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_22
    {
        public object Name { get; set; }
        public Section8[] Sections { get; set; }
    }

    public class Section8
    {
        public string Name { get; set; }
        public Detail8[] Details { get; set; }
    }

    public class Detail8
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class _20
    {
        public Details3 Details { get; set; }
    }

    public class Details3
    {
        public Part_03 part_0 { get; set; }
        public Part_13 part_1 { get; set; }
        public Part_23 part_2 { get; set; }
    }

    public class Part_03
    {
        public object Name { get; set; }
        public Section9[] Sections { get; set; }
    }

    public class Section9
    {
        public string Name { get; set; }
        public Detail9[] Details { get; set; }
    }

    public class Detail9
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_13
    {
        public object Name { get; set; }
        public Section10[] Sections { get; set; }
    }

    public class Section10
    {
        public string Name { get; set; }
        public Detail10[] Details { get; set; }
    }

    public class Detail10
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_23
    {
        public object Name { get; set; }
        public Section11[] Sections { get; set; }
    }

    public class Section11
    {
        public string Name { get; set; }
        public Detail11[] Details { get; set; }
    }

    public class Detail11
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class _50
    {
        public Details4 Details { get; set; }
    }

    public class Details4
    {
        public Part_04 part_0 { get; set; }
        public Part_14 part_1 { get; set; }
        public Part_24 part_2 { get; set; }
    }

    public class Part_04
    {
        public object Name { get; set; }
        public Section12[] Sections { get; set; }
    }

    public class Section12
    {
        public string Name { get; set; }
        public Detail12[] Details { get; set; }
    }

    public class Detail12
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_14
    {
        public object Name { get; set; }
        public Section13[] Sections { get; set; }
    }

    public class Section13
    {
        public string Name { get; set; }
        public Detail13[] Details { get; set; }
    }

    public class Detail13
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_24
    {
        public object Name { get; set; }
        public Section14[] Sections { get; set; }
    }

    public class Section14
    {
        public string Name { get; set; }
        public Detail14[] Details { get; set; }
    }

    public class Detail14
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class _100
    {
        public Details5 Details { get; set; }
    }

    public class Details5
    {
        public Part_05 part_0 { get; set; }
        public Part_15 part_1 { get; set; }
        public Part_25 part_2 { get; set; }
    }

    public class Part_05
    {
        public object Name { get; set; }
        public Section15[] Sections { get; set; }
    }

    public class Section15
    {
        public string Name { get; set; }
        public Detail15[] Details { get; set; }
    }

    public class Detail15
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_15
    {
        public object Name { get; set; }
        public Section16[] Sections { get; set; }
    }

    public class Section16
    {
        public string Name { get; set; }
        public Detail16[] Details { get; set; }
    }

    public class Detail16
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

    public class Part_25
    {
        public object Name { get; set; }
        public Section17[] Sections { get; set; }
    }

    public class Section17
    {
        public string Name { get; set; }
        public Detail17[] Details { get; set; }
    }

    public class Detail17
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public bool IsBold { get; set; }
        public float NumericValue { get; set; }
        public int OperationType { get; set; }
        public int PriorityOrder { get; set; }
        public string Value { get; set; }
        public int ValueGroupType { get; set; }
        public int ValueType { get; set; }
    }

}
