﻿using FluentValidation.Results;

namespace Manage.Touristic.Plan.Transversal.Common
{
    public class ResponseGeneric<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; } = false;
        public string? Message { get; set; }
        public IEnumerable<ValidationFailure> Errors { get; set; }
    }
}
