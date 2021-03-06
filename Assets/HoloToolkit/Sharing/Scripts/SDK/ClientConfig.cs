/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace HoloToolkit.Sharing {

public class ClientConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClientConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ClientConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClientConfig() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SharingClientPINVOKE.delete_ClientConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ClientConfig(ClientRole role) : this(SharingClientPINVOKE.new_ClientConfig((int)role), true) {
  }

  public ClientRole GetRole() {
    ClientRole ret = (ClientRole)SharingClientPINVOKE.ClientConfig_GetRole(swigCPtr);
    return ret;
  }

  public string GetServerAddress() {
    string ret = SharingClientPINVOKE.ClientConfig_GetServerAddress(swigCPtr);
    return ret;
  }

  public bool SetServerAddress(string serverAddress) {
    bool ret = SharingClientPINVOKE.ClientConfig_SetServerAddress(swigCPtr, serverAddress);
    if (SharingClientPINVOKE.SWIGPendingException.Pending) throw SharingClientPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetServerPort() {
    int ret = SharingClientPINVOKE.ClientConfig_GetServerPort(swigCPtr);
    return ret;
  }

  public bool SetServerPort(int port) {
    bool ret = SharingClientPINVOKE.ClientConfig_SetServerPort(swigCPtr, port);
    return ret;
  }

  public LogWriter GetLogWriter() {
    global::System.IntPtr cPtr = SharingClientPINVOKE.ClientConfig_GetLogWriter(swigCPtr);
    LogWriter ret = (cPtr == global::System.IntPtr.Zero) ? null : new LogWriter(cPtr, false);
    return ret;
  }

  public void SetLogWriter(LogWriter logger) {
    SharingClientPINVOKE.ClientConfig_SetLogWriter(swigCPtr, LogWriter.getCPtr(logger));
  }

  public bool GetIsAudioEndpoint() {
    bool ret = SharingClientPINVOKE.ClientConfig_GetIsAudioEndpoint(swigCPtr);
    return ret;
  }

  public void SetIsAudioEndpoint(bool isAudioEndpoint) {
    SharingClientPINVOKE.ClientConfig_SetIsAudioEndpoint(swigCPtr, isAudioEndpoint);
  }

  public bool GetProfilerEnabled() {
    bool ret = SharingClientPINVOKE.ClientConfig_GetProfilerEnabled(swigCPtr);
    return ret;
  }

  public void SetProfilerEnabled(bool enabled) {
    SharingClientPINVOKE.ClientConfig_SetProfilerEnabled(swigCPtr, enabled);
  }

}

}
