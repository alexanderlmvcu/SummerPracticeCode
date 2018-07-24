require "application_system_test_case"

class PotionsTest < ApplicationSystemTestCase
  setup do
    @potion = potions(:one)
  end

  test "visiting the index" do
    visit potions_url
    assert_selector "h1", text: "Potions"
  end

  test "creating a Potion" do
    visit potions_url
    click_on "New Potion"

    fill_in "Name", with: @potion.name
    fill_in "Price", with: @potion.price
    fill_in "Year", with: @potion.year
    click_on "Create Potion"

    assert_text "Potion was successfully created"
    click_on "Back"
  end

  test "updating a Potion" do
    visit potions_url
    click_on "Edit", match: :first

    fill_in "Name", with: @potion.name
    fill_in "Price", with: @potion.price
    fill_in "Year", with: @potion.year
    click_on "Update Potion"

    assert_text "Potion was successfully updated"
    click_on "Back"
  end

  test "destroying a Potion" do
    visit potions_url
    page.accept_confirm do
      click_on "Destroy", match: :first
    end

    assert_text "Potion was successfully destroyed"
  end
end
