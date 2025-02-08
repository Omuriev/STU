// STU Game.All Rights Reserved

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/CharacterMovementComponent.h"
#include "STUCharacterMovementComponent.generated.h"

/**
 *
 */
UCLASS()
class STU_API USTUCharacterMovementComponent : public UCharacterMovementComponent
{
    GENERATED_BODY()

public:
    UPROPERTY(EditDefaultsOnly, BlueprintReadWrite, Category = "Movement", meta = (ClampMin = "1.2", ClampMax = "2.5"))
    float RunModifier = 1.25f;

    virtual float GetMaxSpeed() const override;
};
