using System.Collections.Generic;

interface ILeutenantGeneral
{
    List<Private> PrivatesList { get; }
    void AddPrivate(Private currentPrivate);
}