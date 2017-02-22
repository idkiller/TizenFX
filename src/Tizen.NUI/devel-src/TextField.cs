/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI {

using System;
using System.Runtime.InteropServices;


public class TextField : View {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TextField(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.TextField_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TextField() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_TextField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



public class TextChangedEventArgs : EventArgs
{
   private TextField _textField;

   public TextField TextField
   {
      get
      {
         return _textField;
      }
      set
      {
         _textField = value;
      }
   }
}

public class MaxLengthReachedEventArgs : EventArgs
{
   private TextField _textField;

   public TextField TextField
   {
      get
      {
         return _textField;
      }
      set
      {
         _textField = value;
      }
   }
}


  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate void TextChangedCallbackDelegate(IntPtr textField);
  private DaliEventHandler<object,TextChangedEventArgs> _textFieldTextChangedEventHandler;
  private TextChangedCallbackDelegate _textFieldTextChangedCallbackDelegate;
  
  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate void MaxLengthReachedCallbackDelegate(IntPtr textField);
  private DaliEventHandler<object,MaxLengthReachedEventArgs> _textFieldMaxLengthReachedEventHandler;
  private MaxLengthReachedCallbackDelegate _textFieldMaxLengthReachedCallbackDelegate;

  public event DaliEventHandler<object,TextChangedEventArgs> TextChanged
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_textFieldTextChangedEventHandler == null)
           {
              _textFieldTextChangedEventHandler += value;

              _textFieldTextChangedCallbackDelegate = new TextChangedCallbackDelegate(OnTextChanged);
              this.TextChangedSignal().Connect(_textFieldTextChangedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_textFieldTextChangedEventHandler != null)
           {
              this.TextChangedSignal().Disconnect(_textFieldTextChangedCallbackDelegate);
           }

           _textFieldTextChangedEventHandler -= value;
        }
     }
  }

 private void OnTextChanged(IntPtr textField)
  {
   TextChangedEventArgs e = new TextChangedEventArgs();

   // Populate all members of "e" (TextChangedEventArgs) with real data
   e.TextField = Tizen.NUI.TextField.GetTextFieldFromPtr(textField);

   if (_textFieldTextChangedEventHandler != null)
   {
      //here we send all data to user event handlers
      _textFieldTextChangedEventHandler(this, e);
   }

  }

  public event DaliEventHandler<object,MaxLengthReachedEventArgs> MaxLengthReached
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_textFieldMaxLengthReachedEventHandler == null)
           {
              _textFieldMaxLengthReachedEventHandler += value;

              _textFieldMaxLengthReachedCallbackDelegate = new MaxLengthReachedCallbackDelegate(OnMaxLengthReached);
              this.MaxLengthReachedSignal().Connect(_textFieldMaxLengthReachedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_textFieldMaxLengthReachedEventHandler != null)
           {
              this.MaxLengthReachedSignal().Disconnect(_textFieldMaxLengthReachedCallbackDelegate);
           }

           _textFieldMaxLengthReachedEventHandler -= value;
        }
     }
  }

 private void OnMaxLengthReached(IntPtr textField)
  {
   MaxLengthReachedEventArgs e = new MaxLengthReachedEventArgs();

   // Populate all members of "e" (MaxLengthReachedEventArgs) with real data
   e.TextField = Tizen.NUI.TextField.GetTextFieldFromPtr(textField);

   if (_textFieldMaxLengthReachedEventHandler != null)
   {
      //here we send all data to user event handlers
      _textFieldMaxLengthReachedEventHandler(this, e);
   }

  }

 public static TextField GetTextFieldFromPtr(global::System.IntPtr cPtr) {
   TextField ret = new TextField(cPtr, false);
   if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_TextField_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_TextField_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int RENDERING_BACKEND = NDalicPINVOKE.TextField_Property_RENDERING_BACKEND_get();
    public static readonly int TEXT = NDalicPINVOKE.TextField_Property_TEXT_get();
    public static readonly int PLACEHOLDER_TEXT = NDalicPINVOKE.TextField_Property_PLACEHOLDER_TEXT_get();
    public static readonly int PLACEHOLDER_TEXT_FOCUSED = NDalicPINVOKE.TextField_Property_PLACEHOLDER_TEXT_FOCUSED_get();
    public static readonly int FONT_FAMILY = NDalicPINVOKE.TextField_Property_FONT_FAMILY_get();
    public static readonly int FONT_STYLE = NDalicPINVOKE.TextField_Property_FONT_STYLE_get();
    public static readonly int POINT_SIZE = NDalicPINVOKE.TextField_Property_POINT_SIZE_get();
    public static readonly int MAX_LENGTH = NDalicPINVOKE.TextField_Property_MAX_LENGTH_get();
    public static readonly int EXCEED_POLICY = NDalicPINVOKE.TextField_Property_EXCEED_POLICY_get();
    public static readonly int HORIZONTAL_ALIGNMENT = NDalicPINVOKE.TextField_Property_HORIZONTAL_ALIGNMENT_get();
    public static readonly int VERTICAL_ALIGNMENT = NDalicPINVOKE.TextField_Property_VERTICAL_ALIGNMENT_get();
    public static readonly int TEXT_COLOR = NDalicPINVOKE.TextField_Property_TEXT_COLOR_get();
    public static readonly int PLACEHOLDER_TEXT_COLOR = NDalicPINVOKE.TextField_Property_PLACEHOLDER_TEXT_COLOR_get();
    public static readonly int SHADOW_OFFSET = NDalicPINVOKE.TextField_Property_SHADOW_OFFSET_get();
    public static readonly int SHADOW_COLOR = NDalicPINVOKE.TextField_Property_SHADOW_COLOR_get();
    public static readonly int PRIMARY_CURSOR_COLOR = NDalicPINVOKE.TextField_Property_PRIMARY_CURSOR_COLOR_get();
    public static readonly int SECONDARY_CURSOR_COLOR = NDalicPINVOKE.TextField_Property_SECONDARY_CURSOR_COLOR_get();
    public static readonly int ENABLE_CURSOR_BLINK = NDalicPINVOKE.TextField_Property_ENABLE_CURSOR_BLINK_get();
    public static readonly int CURSOR_BLINK_INTERVAL = NDalicPINVOKE.TextField_Property_CURSOR_BLINK_INTERVAL_get();
    public static readonly int CURSOR_BLINK_DURATION = NDalicPINVOKE.TextField_Property_CURSOR_BLINK_DURATION_get();
    public static readonly int CURSOR_WIDTH = NDalicPINVOKE.TextField_Property_CURSOR_WIDTH_get();
    public static readonly int GRAB_HANDLE_IMAGE = NDalicPINVOKE.TextField_Property_GRAB_HANDLE_IMAGE_get();
    public static readonly int GRAB_HANDLE_PRESSED_IMAGE = NDalicPINVOKE.TextField_Property_GRAB_HANDLE_PRESSED_IMAGE_get();
    public static readonly int SCROLL_THRESHOLD = NDalicPINVOKE.TextField_Property_SCROLL_THRESHOLD_get();
    public static readonly int SCROLL_SPEED = NDalicPINVOKE.TextField_Property_SCROLL_SPEED_get();
    public static readonly int SELECTION_HANDLE_IMAGE_LEFT = NDalicPINVOKE.TextField_Property_SELECTION_HANDLE_IMAGE_LEFT_get();
    public static readonly int SELECTION_HANDLE_IMAGE_RIGHT = NDalicPINVOKE.TextField_Property_SELECTION_HANDLE_IMAGE_RIGHT_get();
    public static readonly int SELECTION_HANDLE_PRESSED_IMAGE_LEFT = NDalicPINVOKE.TextField_Property_SELECTION_HANDLE_PRESSED_IMAGE_LEFT_get();
    public static readonly int SELECTION_HANDLE_PRESSED_IMAGE_RIGHT = NDalicPINVOKE.TextField_Property_SELECTION_HANDLE_PRESSED_IMAGE_RIGHT_get();
    public static readonly int SELECTION_HANDLE_MARKER_IMAGE_LEFT = NDalicPINVOKE.TextField_Property_SELECTION_HANDLE_MARKER_IMAGE_LEFT_get();
    public static readonly int SELECTION_HANDLE_MARKER_IMAGE_RIGHT = NDalicPINVOKE.TextField_Property_SELECTION_HANDLE_MARKER_IMAGE_RIGHT_get();
    public static readonly int SELECTION_HIGHLIGHT_COLOR = NDalicPINVOKE.TextField_Property_SELECTION_HIGHLIGHT_COLOR_get();
    public static readonly int DECORATION_BOUNDING_BOX = NDalicPINVOKE.TextField_Property_DECORATION_BOUNDING_BOX_get();
    public static readonly int INPUT_METHOD_SETTINGS = NDalicPINVOKE.TextField_Property_INPUT_METHOD_SETTINGS_get();
    public static readonly int INPUT_COLOR = NDalicPINVOKE.TextField_Property_INPUT_COLOR_get();
    public static readonly int ENABLE_MARKUP = NDalicPINVOKE.TextField_Property_ENABLE_MARKUP_get();
    public static readonly int INPUT_FONT_FAMILY = NDalicPINVOKE.TextField_Property_INPUT_FONT_FAMILY_get();
    public static readonly int INPUT_FONT_STYLE = NDalicPINVOKE.TextField_Property_INPUT_FONT_STYLE_get();
    public static readonly int INPUT_POINT_SIZE = NDalicPINVOKE.TextField_Property_INPUT_POINT_SIZE_get();
    public static readonly int UNDERLINE = NDalicPINVOKE.TextField_Property_UNDERLINE_get();
    public static readonly int INPUT_UNDERLINE = NDalicPINVOKE.TextField_Property_INPUT_UNDERLINE_get();
    public static readonly int SHADOW = NDalicPINVOKE.TextField_Property_SHADOW_get();
    public static readonly int INPUT_SHADOW = NDalicPINVOKE.TextField_Property_INPUT_SHADOW_get();
    public static readonly int EMBOSS = NDalicPINVOKE.TextField_Property_EMBOSS_get();
    public static readonly int INPUT_EMBOSS = NDalicPINVOKE.TextField_Property_INPUT_EMBOSS_get();
    public static readonly int OUTLINE = NDalicPINVOKE.TextField_Property_OUTLINE_get();
    public static readonly int INPUT_OUTLINE = NDalicPINVOKE.TextField_Property_INPUT_OUTLINE_get();
  
  }

  public class InputStyle : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal InputStyle(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InputStyle obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~InputStyle() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_TextField_InputStyle(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public InputStyle() : this(NDalicPINVOKE.new_TextField_InputStyle(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public enum Mask {
      NONE = 0x0000,
      COLOR = 0x0001,
      FONT_FAMILY = 0x0002,
      POINT_SIZE = 0x0004,
      FONT_STYLE = 0x0008,
      UNDERLINE = 0x0010,
      SHADOW = 0x0020,
      EMBOSS = 0x0040,
      OUTLINE = 0x0080
    }
  
  }

  public TextField () : this (NDalicPINVOKE.TextField_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public TextField(TextField handle) : this(NDalicPINVOKE.new_TextField__SWIG_1(TextField.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public TextField Assign(TextField handle) {
    TextField ret = new TextField(NDalicPINVOKE.TextField_Assign(swigCPtr, TextField.getCPtr(handle)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static TextField DownCast(BaseHandle handle) {
    TextField ret = new TextField(NDalicPINVOKE.TextField_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TextFieldSignal TextChangedSignal() {
    TextFieldSignal ret = new TextFieldSignal(NDalicPINVOKE.TextField_TextChangedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TextFieldSignal MaxLengthReachedSignal() {
    TextFieldSignal ret = new TextFieldSignal(NDalicPINVOKE.TextField_MaxLengthReachedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextField_Dali__Toolkit__TextField__InputStyle__MaskF_t InputStyleChangedSignal() {
    SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextField_Dali__Toolkit__TextField__InputStyle__MaskF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__TextField_Dali__Toolkit__TextField__InputStyle__MaskF_t(NDalicPINVOKE.TextField_InputStyleChangedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum PropertyRange {
    PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
    PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX+1000
  }

  public enum ExceedPolicyType {
    EXCEED_POLICY_ORIGINAL,
    EXCEED_POLICY_CLIP
  }

  public int RenderingBackend
  {
    get
    {
      int temp = 0;
      GetProperty( TextField.Property.RENDERING_BACKEND).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.RENDERING_BACKEND, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string Text
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.TEXT).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.TEXT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string PlaceholderText
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.PLACEHOLDER_TEXT).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.PLACEHOLDER_TEXT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string PlaceholderTextFocused
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.PLACEHOLDER_TEXT_FOCUSED).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.PLACEHOLDER_TEXT_FOCUSED, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string FontFamily
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.FONT_FAMILY).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.FONT_FAMILY, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map FontStyle
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.FONT_STYLE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.FONT_STYLE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public float PointSize
  {
    get
    {
      float temp = 0.0f;
      GetProperty( TextField.Property.POINT_SIZE).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.POINT_SIZE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public int MaxLength
  {
    get
    {
      int temp = 0;
      GetProperty( TextField.Property.MAX_LENGTH).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.MAX_LENGTH, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public int ExceedPolicy
  {
    get
    {
      int temp = 0;
      GetProperty( TextField.Property.EXCEED_POLICY).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.EXCEED_POLICY, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string HorizontalAlignment
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.HORIZONTAL_ALIGNMENT).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.HORIZONTAL_ALIGNMENT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string VerticalAlignment
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.VERTICAL_ALIGNMENT).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.VERTICAL_ALIGNMENT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 TextColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.TEXT_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.TEXT_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 PlaceholderTextColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.PLACEHOLDER_TEXT_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.PLACEHOLDER_TEXT_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector2 ShadowOffset
  {
    get
    {
      Vector2 temp = new Vector2(0.0f,0.0f);
      GetProperty( TextField.Property.SHADOW_OFFSET).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SHADOW_OFFSET, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 ShadowColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.SHADOW_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SHADOW_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 PrimaryCursorColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.PRIMARY_CURSOR_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.PRIMARY_CURSOR_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 SecondaryCursorColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.SECONDARY_CURSOR_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SECONDARY_CURSOR_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public bool EnableCursorBlink
  {
    get
    {
      bool temp = false;
      GetProperty( TextField.Property.ENABLE_CURSOR_BLINK).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.ENABLE_CURSOR_BLINK, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public float CursorBlinkInterval
  {
    get
    {
      float temp = 0.0f;
      GetProperty( TextField.Property.CURSOR_BLINK_INTERVAL).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.CURSOR_BLINK_INTERVAL, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public float CursorBlinkDuration
  {
    get
    {
      float temp = 0.0f;
      GetProperty( TextField.Property.CURSOR_BLINK_DURATION).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.CURSOR_BLINK_DURATION, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public int CursorWidth
  {
    get
    {
      int temp = 0;
      GetProperty( TextField.Property.CURSOR_WIDTH).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.CURSOR_WIDTH, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string GrabHandleImage
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.GRAB_HANDLE_IMAGE).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.GRAB_HANDLE_IMAGE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string GrabHandlePressedImage
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.GRAB_HANDLE_PRESSED_IMAGE).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.GRAB_HANDLE_PRESSED_IMAGE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public float ScrollThreshold
  {
    get
    {
      float temp = 0.0f;
      GetProperty( TextField.Property.SCROLL_THRESHOLD).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SCROLL_THRESHOLD, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public float ScrollSpeed
  {
    get
    {
      float temp = 0.0f;
      GetProperty( TextField.Property.SCROLL_SPEED).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SCROLL_SPEED, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map SelectionHandleImageLeft
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SELECTION_HANDLE_IMAGE_LEFT).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HANDLE_IMAGE_LEFT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map SelectionHandleImageRight
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SELECTION_HANDLE_IMAGE_RIGHT).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HANDLE_IMAGE_RIGHT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map SelectionHandlePressedImageLeft
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SELECTION_HANDLE_PRESSED_IMAGE_LEFT).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HANDLE_PRESSED_IMAGE_LEFT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map SelectionHandlePressedImageRight
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SELECTION_HANDLE_PRESSED_IMAGE_RIGHT).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HANDLE_PRESSED_IMAGE_RIGHT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map SelectionHandleMarkerImageLeft
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SELECTION_HANDLE_MARKER_IMAGE_LEFT).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HANDLE_MARKER_IMAGE_LEFT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map SelectionHandleMarkerImageRight
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SELECTION_HANDLE_MARKER_IMAGE_RIGHT).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HANDLE_MARKER_IMAGE_RIGHT, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 SelectionHighlightColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.SELECTION_HIGHLIGHT_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SELECTION_HIGHLIGHT_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Rectangle DecorationBoundingBox
  {
    get
    {
      Rectangle temp = new Rectangle(0,0,0,0);
      GetProperty( TextField.Property.DECORATION_BOUNDING_BOX).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.DECORATION_BOUNDING_BOX, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map InputMethodSettings
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.INPUT_METHOD_SETTINGS).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_METHOD_SETTINGS, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Vector4 InputColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( TextField.Property.INPUT_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_COLOR, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public bool EnableMarkup
  {
    get
    {
      bool temp = false;
      GetProperty( TextField.Property.ENABLE_MARKUP).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.ENABLE_MARKUP, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public string InputFontFamily
  {
    get
    {
      string temp;
      GetProperty( TextField.Property.INPUT_FONT_FAMILY).Get( out temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_FONT_FAMILY, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map InputFontStyle
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.INPUT_FONT_STYLE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_FONT_STYLE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public float InputPointSize
  {
    get
    {
      float temp = 0.0f;
      GetProperty( TextField.Property.INPUT_POINT_SIZE).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_POINT_SIZE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map Underline
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.UNDERLINE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.UNDERLINE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map InputUnderline
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.INPUT_UNDERLINE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_UNDERLINE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map Shadow
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.SHADOW).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.SHADOW, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map InputShadow
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.INPUT_SHADOW).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_SHADOW, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map Emboss
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.EMBOSS).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.EMBOSS, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map InputEmboss
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.INPUT_EMBOSS).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_EMBOSS, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map Outline
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.OUTLINE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.OUTLINE, new Tizen.NUI.Property.Value( value ) );
    }
  }
  public Tizen.NUI.Property.Map InputOutline
  {
    get
    {
      Tizen.NUI.Property.Map temp = new Tizen.NUI.Property.Map();
      GetProperty( TextField.Property.INPUT_OUTLINE).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( TextField.Property.INPUT_OUTLINE, new Tizen.NUI.Property.Value( value ) );
    }
  }

}

}
