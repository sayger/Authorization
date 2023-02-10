using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase.Auth;
using Firebase;

public class ErrorManager : MonoBehaviour
{
    [SerializeField] private Text error;
    public void UpdateTextError(string text)
    {
        error.text = text;
    }
    public void WhatErrorOut(FirebaseException firebaseException)
    {
        AuthError errorCode = (AuthError)firebaseException.ErrorCode;
        string message = "������ �����������!";
        switch (errorCode)
        {
            case AuthError.None:
                message = "�����!";
                break;
            case AuthError.Unimplemented:
                message = "���������������!";
                break;
            case AuthError.Failure:
                message = "�����! ���������� �����!";
                break;
            case AuthError.InvalidCustomToken:
                message = "���������������� ����������� �����!";
                break;
            case AuthError.CustomTokenMismatch:
                message = "�������������� ����������������� ������!";
                break;
            case AuthError.InvalidCredential:
                message = "�������� ������� ������!";
                break;
            case AuthError.UserDisabled:
                message = "������������ ��������!";
                break;
            case AuthError.AccountExistsWithDifferentCredentials:
                message = "������� ������ ���������� � ������� �������!";
                break;
            case AuthError.OperationNotAllowed:
                message = "�������� �� ���������!";
                break;
            case AuthError.EmailAlreadyInUse:
                message = "��� ����� ��� ������������!";
                break;
            case AuthError.RequiresRecentLogin:
                message = "��������� �������� ����!";
                break;
            case AuthError.CredentialAlreadyInUse:
                message = "������� ������ ��� ������������!";
                break;
            case AuthError.InvalidEmail:
                message = "�������� ����� ����������� �����!";
                break;
            case AuthError.WrongPassword:
                message = "������������ ������";
                break;
            case AuthError.TooManyRequests:
                message = "������� ����� ��������! ���������� �����!";
                break;
            case AuthError.UserNotFound:
                message = "������������ �� ������";
                break;
            case AuthError.ProviderAlreadyLinked:
                message = "������������ ��� � ����";
                break;
            case AuthError.NoSuchProvider:
                message = "��� ������ ����������!";
                break;
            case AuthError.InvalidUserToken:
                message = "�������� ����� ������������!";
                break;
            case AuthError.UserTokenExpired:
                message = "���� �������� ������ ������������ �����!";
                break;
            case AuthError.NetworkRequestFailed:
                message = "������ �������� �������!";
                break;
            case AuthError.InvalidApiKey:
                message = "�������� ���� API!";
                break;
            case AuthError.AppNotAuthorized:
                message = "���������� �� ������������!";
                break;
            case AuthError.UserMismatch:
                message = "�������������� �������������!";
                break;
            case AuthError.WeakPassword:
                message = "������ ������!";
                break;
            case AuthError.NoSignedInUser:
                message = "������������ �� ����� � �������!";
                break;
            case AuthError.ApiNotAvailable:
                message = "Api ����������!";
                break;
            case AuthError.ExpiredActionCode:
                message = "��� �������� � �������� ������ ��������!";
                break;
            case AuthError.InvalidActionCode:
                message = "�������� ��� ��������!";
                break;
            case AuthError.InvalidMessagePayload:
                message = "���������������� ������ ���������!";
                break;
            case AuthError.InvalidPhoneNumber:
                message = "������������ ����� ��������!";
                break;
            case AuthError.MissingPhoneNumber:
                message = "����������� ����� ��������!";
                break;
            case AuthError.InvalidRecipientEmail:
                message = "�������� ����� ����������� ����� ����������!";
                break;
            case AuthError.InvalidSender:
                message = "�������� �����������!";
                break;
            case AuthError.InvalidVerificationCode:
                message = "�������� ����������� ���!";
                break;
            case AuthError.InvalidVerificationId:
                message = "���������������� ������������� �������������!";
                break;
            case AuthError.MissingVerificationCode:
                message = "����������� ��� �������������!";
                break;
            case AuthError.MissingVerificationId:
                message = "����������� ������������� �������������!";
                break;
            case AuthError.MissingEmail:
                message = "����������� �����!";
                break;
            case AuthError.MissingPassword:
                message = "����������� ������!";
                break;
            case AuthError.QuotaExceeded:
                message = "����� ���������!";
                break;
            case AuthError.RetryPhoneAuth:
                message = "��������� ������� �������������� ��������!";
                break;
            case AuthError.SessionExpired:
                message = "������ �������!";
                break;
            case AuthError.AppNotVerified:
                message = "���������� �� ���������!";
                break;
            case AuthError.AppVerificationFailed:
                message = "������ �������� ����������!";
                break;
            case AuthError.CaptchaCheckFailed:
                message = "������ �������� Captcha!";
                break;
            case AuthError.InvalidAppCredential:
                message = "���������������� ������� ������ ����������!";
                break;
            case AuthError.MissingAppCredential:
                message = "����������� ������� ������ ����������!";
                break;
            case AuthError.InvalidClientId:
                message = "�������� ������������� �������!";
                break;
            case AuthError.InvalidContinueUri:
                message = "���������������� ��� �����������!";
                break;
            case AuthError.MissingContinueUri:
                message = "����������� URL �����������!";
                break;
            case AuthError.KeychainError:
                message = "������ ������ ������!";
                break;
            case AuthError.MissingAppToken:
                message = "����������� ����� API!";
                break;
            case AuthError.MissingIosBundleId:
                message = "����������� ������������� ������ !";
                break;
            case AuthError.NotificationNotForwarded:
                message = "����������� �� ����������!";
                break;
            case AuthError.UnauthorizedDomain:
                message = "���������������� �����!";
                break;
            case AuthError.WebContextAlreadyPresented:
                message = "���-�������� ��� �����������!";
                break;
            case AuthError.WebContextCancelled:
                message = "���-�������� �������!";
                break;
            case AuthError.DynamicLinkNotActivated:
                message = "������������ ������ �� ������������!";
                break;
            case AuthError.Cancelled:
                message = "��������!";
                break;
            case AuthError.InvalidProviderId:
                message = "���������������� ������������� ����������!";
                break;
            case AuthError.WebInternalError:
                message = "���������� ���-������!";
                break;
            case AuthError.WebStorateUnsupported:
                message = "��������-������� �� ��������������!";
                break;
            case AuthError.TenantIdMismatch:
                message = "�������������� �������������� ����������!";
                break;
            case AuthError.UnsupportedTenantOperation:
                message = "���������������� �������� ����������!";
                break;
            case AuthError.InvalidLinkDomain:
                message = "���������������� ����� ������!";
                break;
            case AuthError.RejectedCredential:
                message = "����������� ������� ������!";
                break;
            case AuthError.PhoneNumberNotFound:
                message = "����� �������� �� ������!";
                break;
            case AuthError.InvalidTenantId:
                message = "���������������� ������������� ����������!";
                break;
            case AuthError.MissingClientIdentifier:
                message = "����������� ������������� �������!";
                break;
            case AuthError.MissingMultiFactorSession:
                message = "����������� �������������� �����!";
                break;
            case AuthError.MissingMultiFactorInfo:
                message = "����������� �������������� ����������!";
                break;
            case AuthError.InvalidMultiFactorSession:
                message = "���������������� �������������� �����!";
                break;
            case AuthError.MultiFactorInfoNotFound:
                message = "�������������� ���������� �� �������!";
                break;
            case AuthError.AdminRestrictedOperation:
                message = "��������, ������������ ���������������!";
                break;
            case AuthError.UnverifiedEmail:
                message = "������������� ����� ����������� �����!";
                break;
            case AuthError.SecondFactorAlreadyEnrolled:
                message = "������ ������ ��� ���������������!";
                break;
            case AuthError.MaximumSecondFactorCountExceeded:
                message = "��������� ������������ ���������� ��������� ��������!";
                break;
            case AuthError.UnsupportedFirstFactor:
                message = "���������������� ������ ������!";
                break;
            case AuthError.EmailChangeNeedsVerification:
                message = "��������� ������ ����������� ����� ������� �������������!";
                break;
            default:
                break;
        }
        UpdateTextError(message);
    }
}
