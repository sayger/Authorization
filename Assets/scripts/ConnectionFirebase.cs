using UnityEngine;
using Firebase.Auth;
using Firebase;
using Firebase.Database;

public class ConnectionFirebase : MonoBehaviour
{
    public static FirebaseAuth AuthorizationPlayer;
    public static DatabaseReference reference;
    public static FirebaseUser User;
    [SerializeField] private ErrorManager errorManager;
    private void Awake()
    {
        //FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        //{
        //    DependencyStatus dependencyStatus = task.Result;
        //    if (dependencyStatus == DependencyStatus.Available)
        //    {
                reference = FirebaseDatabase.DefaultInstance.RootReference;
        FirebaseAuth defaultInstance = FirebaseAuth.DefaultInstance;
        AuthorizationPlayer = defaultInstance;
        //    }
        //    else
        //    {
        //        errorManager.UpdateTextError("�� ������� ��������� ��� ����������� Firebase: " + dependencyStatus.ToString() + "! ���������� ����� �����!");
        //    }
        //});
    }
   

}
