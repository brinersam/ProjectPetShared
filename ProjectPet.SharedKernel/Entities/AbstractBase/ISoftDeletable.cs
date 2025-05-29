namespace ProjectPet.SharedKernel.Entities.AbstractBase;

public interface ISoftDeletable
{
    void SoftDelete();
    void SoftRestore();
}
