﻿public interface ISoundProducable
{
    string Name { get; }
    int Age { get; }
    string Gender { get; }

    string ProduceSound();


}