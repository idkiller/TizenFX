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

public class VectorFloat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorFloat() {
    DisposeQueue.Instance.Add(this);
  }

  public virtual void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_VectorFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


  public VectorFloat() : this(NDalicPINVOKE.new_VectorFloat__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorFloat(VectorFloat vector) : this(NDalicPINVOKE.new_VectorFloat__SWIG_1(VectorFloat.getCPtr(vector)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public VectorFloat Assign(VectorFloat vector) {
    VectorFloat ret = new VectorFloat(NDalicPINVOKE.VectorFloat_Assign(swigCPtr, VectorFloat.getCPtr(vector)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_float Begin() {
    global::System.IntPtr cPtr = NDalicPINVOKE.VectorFloat_Begin(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_float End() {
    global::System.IntPtr cPtr = NDalicPINVOKE.VectorFloat_End(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_float ValueOfIndex(uint index) {
    SWIGTYPE_p_float ret = new SWIGTYPE_p_float(NDalicPINVOKE.VectorFloat_ValueOfIndex__SWIG_0(swigCPtr, index), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void PushBack(float element) {
    NDalicPINVOKE.VectorFloat_PushBack(swigCPtr, element);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(SWIGTYPE_p_float at, float element) {
    NDalicPINVOKE.VectorFloat_Insert__SWIG_0(swigCPtr, SWIGTYPE_p_float.getCPtr(at), element);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Insert(SWIGTYPE_p_float at, SWIGTYPE_p_float from, SWIGTYPE_p_float to) {
    NDalicPINVOKE.VectorFloat_Insert__SWIG_1(swigCPtr, SWIGTYPE_p_float.getCPtr(at), SWIGTYPE_p_float.getCPtr(from), SWIGTYPE_p_float.getCPtr(to));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reserve(uint count) {
    NDalicPINVOKE.VectorFloat_Reserve(swigCPtr, count);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Resize(uint count) {
    NDalicPINVOKE.VectorFloat_Resize__SWIG_0(swigCPtr, count);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Resize(uint count, float item) {
    NDalicPINVOKE.VectorFloat_Resize__SWIG_1(swigCPtr, count, item);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_float Erase(SWIGTYPE_p_float iterator) {
    global::System.IntPtr cPtr = NDalicPINVOKE.VectorFloat_Erase__SWIG_0(swigCPtr, SWIGTYPE_p_float.getCPtr(iterator));
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_float Erase(SWIGTYPE_p_float first, SWIGTYPE_p_float last) {
    global::System.IntPtr cPtr = NDalicPINVOKE.VectorFloat_Erase__SWIG_1(swigCPtr, SWIGTYPE_p_float.getCPtr(first), SWIGTYPE_p_float.getCPtr(last));
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Remove(SWIGTYPE_p_float iterator) {
    NDalicPINVOKE.VectorFloat_Remove(swigCPtr, SWIGTYPE_p_float.getCPtr(iterator));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Swap(VectorFloat vector) {
    NDalicPINVOKE.VectorFloat_Swap(swigCPtr, VectorFloat.getCPtr(vector));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    NDalicPINVOKE.VectorFloat_Clear(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Release() {
    NDalicPINVOKE.VectorFloat_Release(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public static readonly int BaseType = NDalicPINVOKE.VectorFloat_BaseType_get();

}

}
