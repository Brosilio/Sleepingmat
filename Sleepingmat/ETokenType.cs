﻿namespace Sleepingmat
{
    internal enum ETokenType
    {
        Identifier, StringLiteral, NumberLiteral,
        LParen, RParen,
        LBrace, RBrace,
        LSquareBracket, RSquareBracket,
        Comma, Semicolon, Colon, Pound, Period,
        EOF, UnknownTokenType
    }
}
