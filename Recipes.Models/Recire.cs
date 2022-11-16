using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Recipes.Models
{


    public class CA
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class CHOCDF
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class CHOCDFNet
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class CHOLE
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Digest
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("schemaOrgTag")]
        public string SchemaOrgTag { get; set; }

        [JsonPropertyName("total")]
        public double? Total { get; set; }

        [JsonPropertyName("hasRDI")]
        public bool? HasRDI { get; set; }

        [JsonPropertyName("daily")]
        public double? Daily { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("sub")]
        public List<Sub> Sub { get; set; }
    }

    public class ENERCKCAL
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FAMS
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FAPU
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FASAT
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FAT
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FATRN
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FE
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FIBTG
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FOLAC
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FOLDFE
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class FOLFD
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Hit
    {
        [JsonPropertyName("recipe")]
        public Recipe Recipe { get; set; }

        [JsonPropertyName("_links")]
        public Links Links { get; set; }
    }

    public class Images
    {
        [JsonPropertyName("THUMBNAIL")]
        public THUMBNAIL THUMBNAIL { get; set; }

        [JsonPropertyName("SMALL")]
        public SMALL SMALL { get; set; }

        [JsonPropertyName("REGULAR")]
        public REGULAR REGULAR { get; set; }

        [JsonPropertyName("LARGE")]
        public LARGE LARGE { get; set; }
    }

    public class Ingredient
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("measure")]
        public string Measure { get; set; }

        [JsonPropertyName("food")]
        public string Food { get; set; }

        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        [JsonPropertyName("foodCategory")]
        public string FoodCategory { get; set; }

        [JsonPropertyName("foodId")]
        public string FoodId { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }

    public class K
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class LARGE
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }
    }

    public class Links
    {
        [JsonPropertyName("next")]
        public Next Next { get; set; }

        [JsonPropertyName("self")]
        public Self Self { get; set; }
    }

    public class MG
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class NA
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Next
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }

    public class NIA
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class P
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class PROCNT
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Recipe
    {
        [JsonPropertyName("uri")]
        public string Uri { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("images")]
        public Images Images { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("shareAs")]
        public string ShareAs { get; set; }

        [JsonPropertyName("yield")]
        public double? Yield { get; set; }

        [JsonPropertyName("dietLabels")]
        public List<string> DietLabels { get; set; }

        [JsonPropertyName("healthLabels")]
        public List<string> HealthLabels { get; set; }

        [JsonPropertyName("cautions")]
        public List<string> Cautions { get; set; }

        [JsonPropertyName("ingredientLines")]
        public List<string> IngredientLines { get; set; }

        [JsonPropertyName("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonPropertyName("calories")]
        public double? Calories { get; set; }

        [JsonPropertyName("totalWeight")]
        public double? TotalWeight { get; set; }

        [JsonPropertyName("totalTime")]
        public double? TotalTime { get; set; }

        [JsonPropertyName("cuisineType")]
        public List<string> CuisineType { get; set; }

        [JsonPropertyName("mealType")]
        public List<string> MealType { get; set; }

        [JsonPropertyName("dishType")]
        public List<string> DishType { get; set; }

        [JsonPropertyName("totalNutrients")]
        public TotalNutrients TotalNutrients { get; set; }

        [JsonPropertyName("totalDaily")]
        public TotalDaily TotalDaily { get; set; }

        [JsonPropertyName("digest")]
        public List<Digest> Digest { get; set; }
    }

    public class REGULAR
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }
    }

    public class RIBF
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("from")]
        public int? From { get; set; }

        [JsonPropertyName("to")]
        public int? To { get; set; }

        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        [JsonPropertyName("hits")]
        public List<Hit> Hits { get; set; }
    }

    public class Self
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }
    }

    public class SMALL
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }
    }

    public class Sub
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("schemaOrgTag")]
        public string SchemaOrgTag { get; set; }

        [JsonPropertyName("total")]
        public double? Total { get; set; }

        [JsonPropertyName("hasRDI")]
        public bool? HasRDI { get; set; }

        [JsonPropertyName("daily")]
        public double? Daily { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class SUGAR
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class SUGARAdded
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class SugarAlcohol
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class THIA
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class THUMBNAIL
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }
    }

    public class TOCPHA
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class TotalDaily
    {
        [JsonPropertyName("ENERC_KCAL")]
        public ENERCKCAL ENERCKCAL { get; set; }

        [JsonPropertyName("FAT")]
        public FAT FAT { get; set; }

        [JsonPropertyName("FASAT")]
        public FASAT FASAT { get; set; }

        [JsonPropertyName("CHOCDF")]
        public CHOCDF CHOCDF { get; set; }

        [JsonPropertyName("FIBTG")]
        public FIBTG FIBTG { get; set; }

        [JsonPropertyName("PROCNT")]
        public PROCNT PROCNT { get; set; }

        [JsonPropertyName("CHOLE")]
        public CHOLE CHOLE { get; set; }

        [JsonPropertyName("NA")]
        public NA NA { get; set; }

        [JsonPropertyName("CA")]
        public CA CA { get; set; }

        [JsonPropertyName("MG")]
        public MG MG { get; set; }

        [JsonPropertyName("K")]
        public K K { get; set; }

        [JsonPropertyName("FE")]
        public FE FE { get; set; }

        [JsonPropertyName("ZN")]
        public ZN ZN { get; set; }

        [JsonPropertyName("P")]
        public P P { get; set; }

        [JsonPropertyName("VITA_RAE")]
        public VITARAE VITARAE { get; set; }

        [JsonPropertyName("VITC")]
        public VITC VITC { get; set; }

        [JsonPropertyName("THIA")]
        public THIA THIA { get; set; }

        [JsonPropertyName("RIBF")]
        public RIBF RIBF { get; set; }

        [JsonPropertyName("NIA")]
        public NIA NIA { get; set; }

        [JsonPropertyName("VITB6A")]
        public VITB6A VITB6A { get; set; }

        [JsonPropertyName("FOLDFE")]
        public FOLDFE FOLDFE { get; set; }

        [JsonPropertyName("VITB12")]
        public VITB12 VITB12 { get; set; }

        [JsonPropertyName("VITD")]
        public VITD VITD { get; set; }

        [JsonPropertyName("TOCPHA")]
        public TOCPHA TOCPHA { get; set; }

        [JsonPropertyName("VITK1")]
        public VITK1 VITK1 { get; set; }
    }

    public class TotalNutrients
    {
        [JsonPropertyName("ENERC_KCAL")]
        public ENERCKCAL ENERCKCAL { get; set; }

        [JsonPropertyName("FAT")]
        public FAT FAT { get; set; }

        [JsonPropertyName("FASAT")]
        public FASAT FASAT { get; set; }

        [JsonPropertyName("FATRN")]
        public FATRN FATRN { get; set; }

        [JsonPropertyName("FAMS")]
        public FAMS FAMS { get; set; }

        [JsonPropertyName("FAPU")]
        public FAPU FAPU { get; set; }

        [JsonPropertyName("CHOCDF")]
        public CHOCDF CHOCDF { get; set; }

        [JsonPropertyName("CHOCDF.net")]
        public CHOCDFNet CHOCDFNet { get; set; }

        [JsonPropertyName("FIBTG")]
        public FIBTG FIBTG { get; set; }

        [JsonPropertyName("SUGAR")]
        public SUGAR SUGAR { get; set; }

        [JsonPropertyName("SUGAR.added")]
        public SUGARAdded SUGARAdded { get; set; }

        [JsonPropertyName("PROCNT")]
        public PROCNT PROCNT { get; set; }

        [JsonPropertyName("CHOLE")]
        public CHOLE CHOLE { get; set; }

        [JsonPropertyName("NA")]
        public NA NA { get; set; }

        [JsonPropertyName("CA")]
        public CA CA { get; set; }

        [JsonPropertyName("MG")]
        public MG MG { get; set; }

        [JsonPropertyName("K")]
        public K K { get; set; }

        [JsonPropertyName("FE")]
        public FE FE { get; set; }

        [JsonPropertyName("ZN")]
        public ZN ZN { get; set; }

        [JsonPropertyName("P")]
        public P P { get; set; }

        [JsonPropertyName("VITA_RAE")]
        public VITARAE VITARAE { get; set; }

        [JsonPropertyName("VITC")]
        public VITC VITC { get; set; }

        [JsonPropertyName("THIA")]
        public THIA THIA { get; set; }

        [JsonPropertyName("RIBF")]
        public RIBF RIBF { get; set; }

        [JsonPropertyName("NIA")]
        public NIA NIA { get; set; }

        [JsonPropertyName("VITB6A")]
        public VITB6A VITB6A { get; set; }

        [JsonPropertyName("FOLDFE")]
        public FOLDFE FOLDFE { get; set; }

        [JsonPropertyName("FOLFD")]
        public FOLFD FOLFD { get; set; }

        [JsonPropertyName("FOLAC")]
        public FOLAC FOLAC { get; set; }

        [JsonPropertyName("VITB12")]
        public VITB12 VITB12 { get; set; }

        [JsonPropertyName("VITD")]
        public VITD VITD { get; set; }

        [JsonPropertyName("TOCPHA")]
        public TOCPHA TOCPHA { get; set; }

        [JsonPropertyName("VITK1")]
        public VITK1 VITK1 { get; set; }

        [JsonPropertyName("Sugar.alcohol")]
        public SugarAlcohol SugarAlcohol { get; set; }

        [JsonPropertyName("WATER")]
        public WATER WATER { get; set; }
    }

    public class VITARAE
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class VITB12
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class VITB6A
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class VITC
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class VITD
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class VITK1
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class WATER
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }

    public class ZN
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }


}
