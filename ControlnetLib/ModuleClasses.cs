using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ControlnetLib
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Canny
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class ClipVision
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class Color
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Depth
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class DepthLeres
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class DepthLeres2
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class DepthZoe
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class DwOpenposeFull
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Hed
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class HedSafe
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Inpaint
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class InpaintOnly
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class InpaintOnlyLama
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class Invert
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class Lineart
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class LineartAnime
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class LineartAnimeDenoise
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class LineartCoarse
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class LineartStandard
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class MediapipeFace
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Mlsd
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class ModuleDetail
    {
        public None none { get; set; }
        public Canny canny { get; set; }
        public Depth depth { get; set; }
        public DepthLeres depth_leres { get; set; }
        public Hed hed { get; set; }
        public HedSafe hed_safe { get; set; }
        public MediapipeFace mediapipe_face { get; set; }
        public Mlsd mlsd { get; set; }
        public NormalMap normal_map { get; set; }
        public Openpose openpose { get; set; }
        public OpenposeHand openpose_hand { get; set; }
        public OpenposeFace openpose_face { get; set; }
        public OpenposeFaceonly openpose_faceonly { get; set; }
        public OpenposeFull openpose_full { get; set; }
        public DwOpenposeFull dw_openpose_full { get; set; }
        public ClipVision clip_vision { get; set; }
        public Color color { get; set; }
        public Pidinet pidinet { get; set; }
        public PidinetSafe pidinet_safe { get; set; }
        public PidinetSketch pidinet_sketch { get; set; }
        public PidinetScribble pidinet_scribble { get; set; }
        public ScribbleXdog scribble_xdog { get; set; }
        public ScribbleHed scribble_hed { get; set; }
        public Segmentation segmentation { get; set; }
        public Threshold threshold { get; set; }
        public DepthZoe depth_zoe { get; set; }
        public NormalBae normal_bae { get; set; }
        public OneformerCoco oneformer_coco { get; set; }
        public OneformerAde20k oneformer_ade20k { get; set; }
        public Lineart lineart { get; set; }
        public LineartCoarse lineart_coarse { get; set; }
        public LineartAnime lineart_anime { get; set; }
        public LineartStandard lineart_standard { get; set; }
        public Shuffle shuffle { get; set; }
        public TileResample tile_resample { get; set; }
        public Invert invert { get; set; }
        public LineartAnimeDenoise lineart_anime_denoise { get; set; }
        public ReferenceOnly reference_only { get; set; }
        public ReferenceAdain reference_adain { get; set; }

        [JsonProperty("reference_adain+attn")]
        public ReferenceAdainAttn reference_adainattn { get; set; }
        public Inpaint inpaint { get; set; }
        public InpaintOnly inpaint_only { get; set; }

        [JsonProperty("inpaint_only+lama")]
        public InpaintOnlyLama inpaint_onlylama { get; set; }
        public TileColorfix tile_colorfix { get; set; }

        [JsonProperty("tile_colorfix+sharp")]
        public TileColorfixSharp tile_colorfixsharp { get; set; }
    }

    public class None
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class NormalBae
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class NormalMap
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class OneformerAde20k
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class OneformerCoco
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class Openpose
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class OpenposeFace
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class OpenposeFaceonly
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class OpenposeFull
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class OpenposeHand
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class Pidinet
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class PidinetSafe
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class PidinetScribble
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class PidinetSketch
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class ReferenceAdain
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class ReferenceAdainAttn
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class ReferenceOnly
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Modules
    {
        public List<string> module_list { get; set; }
        public ModuleDetail module_detail { get; set; }
    }

    public class ScribbleHed
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class ScribbleXdog
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Segmentation
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class Shuffle
    {
        public bool model_free { get; set; }
        public List<object> sliders { get; set; }
    }

    public class Slider
    {
        public string name { get; set; }
        public double value { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double step { get; set; }
    }

    public class Threshold
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class TileColorfix
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class TileColorfixSharp
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }

    public class TileResample
    {
        public bool model_free { get; set; }
        public List<Slider> sliders { get; set; }
    }


}
